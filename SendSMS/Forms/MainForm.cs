namespace SendSMS.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using RestApiClient;

    using SendSMS.Data;
    using SendSMS.Models;

    using System.Diagnostics;
    using System.Text;

    using Group = SendSMS.Models.Group;
    using Message = SendSMS.Models.Message;

    public partial class MainForm : Form
    {
        private readonly DbManager db;

        readonly RestService service = new RestService();
        private string sessionId;
        private List<Contact> deliveryContacts = new List<Contact>();
        private bool restartWorker;
        private readonly FilterForm filterForm = new FilterForm();

        public MainForm()
        {
            this.InitializeComponent();
            this.db = new DbManager();
            this.backgroundWorker.RunWorkerAsync();
            this.LoadGroups();
            this.LoadContacts();
            this.LoadSettings();
            this.LoadDelivery();


            if (this.contactsGridView.Rows.Count == 0)
            {
                this.removeContactButton.Enabled = false;
                this.editContactButton.Enabled = false;
            }
        }

        private void LoadDelivery()
        {
            this.sendedSource.DataSource = this.db.GetDeliveries();
        }

        private void LoadGroups()
        {

            this.groupsBindingSource.DataSource = this.db.GetGroups();
            this.groupGridView.DataSource = this.groupsBindingSource;

        }

        private void LoadContacts()
        {
            if (this.groupGridView.CurrentRow != null && this.groupGridView.CurrentRow.Index == 0)
            {
                this.contactsBindingSource.DataSource = this.db.GetContacts();
            }
            else
            {
                var id = ((Group)this.groupsBindingSource.Current).Id;
                this.contactsBindingSource.DataSource = this.db.GetContactsByGroup(id);
            }
        }

        private void AddGroupButtonClick(object sender, EventArgs e)
        {
            using (var form = new GroupForm(this.groupsBindingSource.DataSource as List<Group>))
            {
                DialogResult ok = form.ShowDialog(this);
                if (ok == DialogResult.OK)
                {
                    this.db.SaveGroup(form.Group);
                    this.LoadGroups();
                }
            }
        }

        private void RemoveGroupButtonClick(object sender, EventArgs e)
        {
            this.RemoveGroup();
            this.GroupGridViewCellClick(sender, e);
        }

        private void RemoveGroup()
        {
            var group = this.groupsBindingSource.Current as Group;
            this.db.DeleteGroup(group);
            this.LoadGroups();
        }

        private void GroupGridViewCellClick(object sender, EventArgs e)
        {
            if (this.groupGridView.CurrentRow != null && this.groupGridView.CurrentRow.Index == 0)
            {
                this.removeGroupButton.Enabled = false;
                this.editGroupButton.Enabled = false;
            }
            else
            {

                this.removeGroupButton.Enabled = true;
                this.editGroupButton.Enabled = true;
            }
            this.LoadContacts();
            if (this.contactsGridView.Rows.Count == 0)
            {
                this.editContactButton.Enabled = false;
                this.removeContactButton.Enabled = false;
            }
            else
            {
                this.editContactButton.Enabled = true;
                this.removeContactButton.Enabled = true;
            }

        }

        private void EditGroupButtonClick(object sender, EventArgs e)
        {
            this.EditGroup();
        }

        private void EditGroup()
        {
            var group = this.groupsBindingSource.Current as Group;
            using (var form = new GroupForm(@group, this.groupsBindingSource.DataSource as List<Group>))
            {
                DialogResult ok = form.ShowDialog(this);
                if (ok == DialogResult.OK)
                {
                    this.db.UpdateGroup(form.Group);
                    this.LoadGroups();
                }
            }
        }

        private void GroupGridViewCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.LoadContacts();
        }

        private void ContactsGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.contactsGridView.Rows.Count > 0 && this.contactsGridView.Columns[e.ColumnIndex].Name == "SexImage" && this.contactsGridView.Rows[e.RowIndex].Cells["Sex"].Value != null)
            {
                var sex = Int32.Parse(this.contactsGridView.Rows[e.RowIndex].Cells["Sex"].Value.ToString());
                switch (sex)
                {
                    case 1:
                        e.Value = Properties.Resources.Male;
                        break;
                    case 2:
                        e.Value = Properties.Resources.Female;
                        break;
                    default:
                        e.Value = Properties.Resources.Unknown;
                        break;
                }
            }
        }

        private void AddContactButtonClick(object sender, EventArgs e)
        {
            using (var form = new ContactForm(this.groupsBindingSource.DataSource as List<Group>))
            {
                DialogResult ok = form.ShowDialog(this);
                if (ok == DialogResult.OK)
                {
                    if (form.EditMode)
                        this.db.UpdateContact(form.Contact);
                    else
                        this.db.SaveContact(form.Contact);
                    this.LoadContacts();
                    this.LoadGroups();
                    this.removeContactButton.Enabled = true;
                    this.editContactButton.Enabled = true;
                }
            }

        }

        private void EditContactButtonClick(object sender, EventArgs e)
        {
            this.EditContact();
        }

        private void EditContact()
        {
            var contact = this.contactsBindingSource.Current as Contact;
            using (var form = new ContactForm(contact, this.groupsBindingSource.DataSource as List<Group>))
            {
                DialogResult ok = form.ShowDialog(this);
                if (ok == DialogResult.OK)
                {
                    this.db.UpdateContact(form.Contact);
                    this.LoadContacts();
                    this.LoadGroups();
                }
            }
        }

        private void RemoveContactButtonClick(object sender, EventArgs e)
        {
            this.RemoveContact();

            if (this.contactsGridView.Rows.Count == 0)
            {
                this.removeContactButton.Enabled = false;
                this.editContactButton.Enabled = false;
            }
        }

        private void RemoveContact()
        {
            var contact = this.contactsBindingSource.Current as Contact;
            this.db.DeleteContact(contact);
            this.LoadContacts();
            this.LoadGroups();
        }

        private void EditContactButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditContact();
        }

        private void GroupGridViewCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.groupGridView.CurrentRow != null && this.groupGridView.CurrentRow.Index != 0)
                this.EditGroup();
        }

        private void ImportDumpButtonClick(object sender, EventArgs e)
        {
            this.openFileDialog.FileName = "";
            this.openFileDialog.Filter = @"Файлы дампа (*.ebd)|*.ebd|Все файлы (*.*)|*.*";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Contact> contacts = Utils.ImportFromDump(this.openFileDialog.FileName);
                var group = new Group { Name = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") };
                group.Id = this.db.SaveGroup(group);
                foreach (var contact in contacts)
                {
                    if (this.db.GetContactByPhone(contact.Phone) == null)
                    {
                        contact.Group = group;
                        this.db.SaveContact(contact);
                    }
                }
                this.LoadContacts();
                this.LoadGroups();
                this.groupGridView.Rows[this.groupsBindingSource.Count - 1].Selected = true;
                this.editGroupButton.Enabled = true;
                this.removeGroupButton.Enabled = true;

                MessageBox.Show(@"Импорт данных завершен.", @"Импорт данных");
            }
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            this.CheckBalance();
        }

        private void CheckBalance()
        {
            try
            {
                var user = this.db.GetCredentials();
                if (string.IsNullOrEmpty(user.Login))
                {
                    this.statusLabel.Text = @"Введите логин и пароль в настройках";
                    return;
                }
                this.loginTextBox.Text = user.Login;
                this.passwordTextBox.Text = user.Password;

                this.sessionId = this.service.GetSessionId(user.Login, user.Password);
                decimal balance = this.service.GetBalance(this.sessionId);
                this.statusLabel.Text = user.Login + ", ваш баланс " + balance + " руб.";
            }
            catch (RestApiException ex)
            {
                if (ex.ErrorResult.Code == 4)
                    this.statusLabel.Text = "Неверный логин или пароль";
            }
            catch
            {
                this.statusLabel.Text = "Ошибка входа";
            }
        }

        private void AuthButtonClick(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Загрузка данных";
            this.db.SetCredentials(this.loginTextBox.Text, this.passwordTextBox.Text);
            this.SaveSettings();
            if (this.backgroundWorker.IsBusy)
            {
                this.restartWorker = true;
                this.backgroundWorker.CancelAsync();
            }
            else
                this.backgroundWorker.RunWorkerAsync();
        }

        private void UseAuthCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (this.useAuthCheckBox.Checked)
            {
                this.proxyLoginTextBox.Enabled = true;
                this.proxyPasswordTextBox.Enabled = true;
                this.proxyLoginLabel.Enabled = true;
                this.proxyPasswordLabel.Enabled = true;
            }

            else
            {
                this.proxyLoginTextBox.Enabled = false;
                this.proxyPasswordTextBox.Enabled = false;
                this.proxyLoginLabel.Enabled = false;
                this.proxyPasswordLabel.Enabled = false;
            }

        }

        private void SetMarker(string marker)
        {
            var selectionStart = this.messageTextBox.SelectionStart;
            this.messageTextBox.Text = this.messageTextBox.Text.Insert(selectionStart, marker);
            this.messageTextBox.SelectionStart = selectionStart + marker.Length;
            this.messageTextBox.Focus();
        }

        private void MenuItemClick(object sender, EventArgs e)
        {
            if (sender == this.firstnameMenuItem)
            {
                this.SetMarker("%firstname%");
            }
            else if (sender == this.lastnameMenuItem)
            {
                this.SetMarker("%lastname%");
            }
            else if (sender == this.patronymicMenuItem)
            {
                this.SetMarker("%patronymic%");
            }
            else if (sender == this.honorificMenuItem)
            {
                this.SetMarker("%honorific%");
            }
        }

        private string PrepareMessage(Contact contact, string msg)
        {
            string value = msg.Replace("%firstname%", contact.FirstName).Replace("%lastname%", contact.LastName).Replace("%patronymic%", contact.Patronymic);
            if (contact.Sex == 1)
            {
                value = value.Replace("%honorific%", "Уважаемый");

            }
            else if (contact.Sex == 2)
            {
                value = value.Replace("%honorific%", "Уважаемая");
            }
            else
            {
                value = value.Replace("%honorific%", "Уважаемый(ая)");
            }
            if (this.translitCheckBox.Checked)
                value = Utils.TranslitText(value);
            return value;
        }

        private void MessageTextBoxTextChanged(object sender, EventArgs e)
        {
            var msg = this.messageTextBox.Text;
            int msgLength = 160;
            if (Regex.Match(msg, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success)
            {
                msgLength = 70;
            }
            this.countSymbolsLabel.Text = msg.Length + " символов / " + (msg.Length / msgLength + 1) + " SMS";
            this.SetMessage();
        }

        private void SetMessage()
        {
            var tmp = new List<Contact>();
            foreach (Contact contact in this.deliveryContacts)
            {
                contact.Message = this.PrepareMessage(contact, this.messageTextBox.Text);
                tmp.Add(contact);
            }
            this.deliveryContacts = tmp;
            this.deliveryBindingSource.DataSource = this.deliveryContacts;
        }

        private void HelpButtonClick(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutBox())
            {
                aboutForm.ShowDialog(this);
            }

        }

        private void AddToDeliveryButtonClick(object sender, EventArgs e)
        {
            var selectedRows = this.contactsGridView.SelectedRows.Cast<DataGridViewRow>();
            this.deliveryContacts = selectedRows.Select(r => r.DataBoundItem).Cast<Contact>().ToList();
            this.deliveryBindingSource.DataSource = this.deliveryContacts;
            this.deliveryGridView.DataSource = this.deliveryBindingSource;

            this.deliveryGridView.Columns["deliveryPhone"].DisplayIndex = 1;
            this.deliveryGridView.Columns["deliveryMessage"].DisplayIndex = 2;

        }

        private void DeliveryBindingSourceDataSourceChanged(object sender, EventArgs e)
        {
            this.deliveryStatusLabel.Text = "Количество получателей: " + this.deliveryBindingSource.Count;
        }

        private void RemoveNumberButtonClick(object sender, EventArgs e)
        {
            this.deliveryBindingSource.RemoveCurrent();
            this.deliveryStatusLabel.Text = "Количество получателей: " + this.deliveryBindingSource.Count;
        }

        private void AddNumbersButtonClick(object sender, EventArgs e)
        {
            using (var form = new AddContactForm())
            {
                //                DialogResult ok = form.ShowDialog(this);
                //                if (ok == DialogResult.OK)
                //                {
                form.ShowDialog(this);
                this.deliveryContacts.AddRange(form.Contacts);
                this.deliveryContacts = this.deliveryContacts.Distinct().ToList();
                this.deliveryBindingSource.DataSource = this.deliveryContacts;
                this.deliveryGridView.DataSource = this.deliveryBindingSource;
                //                }
                this.SetMessage();
            }
            this.deliveryStatusLabel.Text = "Количество получателей: " + this.deliveryBindingSource.Count;
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == 1)
            {
                this.deliveryNameTextBox.Text = "SMS " + DateTime.Now.ToShortTimeString();
            }
            if (this.tabControl.SelectedIndex == 2)
                this.sendedSource.DataSource = this.db.GetDeliveries();
            this.RemoveContactsButtonCheck();
        }

        private void RemoveContactsButtonCheck(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.RemoveContactsButtonCheck();
        }

        private void RemoveContactsButtonCheck(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.RemoveContactsButtonCheck();
        }

        private void RemoveContactsButtonCheck()
        {
            this.removeNumberButton.Enabled = this.deliveryGridView.Rows.Count != 0;
        }

        private void DeliveryButtonClick(object sender, EventArgs e)
        {
            if (this.deliveryContacts.Count > 0)
            {

                if (string.IsNullOrEmpty(this.sessionId))
                {
                    MessageBox.Show("Ошибка авторизации.\nПожалуйста, введите правильный логин и пароль,\nа затем повторите попытку.", "Отправка сообщений");
                    this.tabControl.SelectTab(3);
                    return;
                }

                try
                {
                    this.SendMessages();
                    this.CheckBalance();

                    this.LoadDelivery();
                    this.messageTextBox.Text = "";
                    this.deliveryBindingSource.Clear();

                    this.tabControl.SelectTab(2);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Ошибка взаимодействия с сервисом.", "Отправка сообщений", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Нет сообщений для рассылки.", "Отправка сообщений");
            }
        }

        private void SendMessages()
        {
            var list = new List<Contact>();
            long id = this.db.SaveDelivery(this.deliveryNameTextBox.Text);
            foreach (var contact in this.deliveryContacts)
            {
                string messageId = this.service.SendMessage(this.sessionId, this.senderTextBox.Text, contact.Phone, contact.Message)[0];
                MessageStateInfo state = this.service.GetState(this.sessionId, messageId);
                this.db.SaveMessage(new Message
                                   {
                                       DeliveryId = id,
                                       ContactId = contact.Id,
                                       ReportedDate = state.CreationDateUtc,
                                       SubmittedDate = state.SubmittedDateUtc,
                                       MessageId = messageId,
                                       Phone = contact.Phone,
                                       Text = contact.Message,
                                       Status = (int)state.State
                                   });
            }

            this.deliveryContacts = new List<Contact>();
        }

        private void SendMessagesBulk()
        {
            var phones = (from contact in this.deliveryContacts
                          select contact.Phone).ToList();
            List<string> list = this.service.SendMessagesBulk(this.sessionId, this.senderTextBox.Text, phones, this.messageTextBox.Text);
            this.db.SaveDelivery(this.deliveryNameTextBox.Text);

            this.deliveryContacts = new List<Contact>();
        }


        private void OptionsPageLeave(object sender, EventArgs e)
        {
            this.settingsBackgroundWorker.RunWorkerAsync();
        }

        private void SettingsBackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            this.SetServiceProxy();
            this.SaveSettings();
        }

        private void SaveSettings()
        {
            this.db.SetCredentials(this.loginTextBox.Text, this.passwordTextBox.Text);
            this.db.SetSender(this.senderTextBox.Text);
            var settings = new Dictionary<string, string>
                               {
                                   {"proxyServer", this.proxyAddressTextBox.Text},
                                   {"proxyPort", this.proxyPortNumericUpDown.Text},
                                   {"proxyLogin", this.proxyLoginTextBox.Text},
                                   {"proxyPassword", this.proxyPasswordTextBox.Text}
                               };
            this.db.SaveSettings(settings);
        }

        private void LoadSettings()
        {
            this.senderTextBox.Text = this.db.GetSender();
            var settings = this.db.LoadSettings();
            foreach (var setting in settings)
            {
                if (setting.Key == "proxyServer")
                {
                    this.proxyAddressTextBox.Text = setting.Value;
                }
                else if (setting.Key == "proxyPort")
                {
                    this.proxyPortNumericUpDown.Text = setting.Value;
                }
                else if (setting.Key == "proxyLogin")
                {
                    this.proxyLoginTextBox.Text = setting.Value;
                    if (!string.IsNullOrEmpty(setting.Value))
                        this.useAuthCheckBox.Checked = true;
                }
                else if (setting.Key == "proxyPassword")
                {
                    this.proxyPasswordTextBox.Text = setting.Value;
                }
            }
            this.SetServiceProxy();
        }

        private void SetServiceProxy()
        {
            WebProxy proxy = null;
            if (!string.IsNullOrEmpty(this.proxyAddressTextBox.Text))
            {
                proxy = new WebProxy(this.proxyAddressTextBox.Text, Int32.Parse(this.proxyPortNumericUpDown.Value.ToString()));

                if (this.useAuthCheckBox.Checked)
                    proxy.Credentials = new NetworkCredential(this.proxyLoginTextBox.Text, this.proxyPasswordTextBox.Text);
            }

            this.service.WebProxy = proxy;
        }

        private void ProxyGroupBoxLeave(object sender, EventArgs e)
        {
            this.SetServiceProxy();
        }

        private void MessageTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!this.translitCheckBox.Checked || char.IsControl(e.KeyChar))
                return;
            string str1 = this.messageTextBox.Text.Substring(0, this.messageTextBox.SelectionStart);
            string str2 = this.messageTextBox.Text.Substring(str1.Length);
            string str3 = Utils.TranslitChar(e.KeyChar.ToString());
            this.messageTextBox.Text = str1 + str3 + str2;
            this.messageTextBox.SelectionStart = str1.Length + str3.Length;
            e.Handled = true;
        }

        private void TranslitCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (this.translitCheckBox.Checked)
                this.messageTextBox.Text = Utils.TranslitText(this.messageTextBox.Text);
            else
                this.messageTextBox.Text = Utils.TranslitText(this.messageTextBox.Text, true)
                    .Replace("%фирстнаме%", "%firstname%")
                    .Replace("%ластнаме%", "%lastname%")
                    .Replace("%патронымиц%", "%patronymic%")
                    .Replace("%hонорифиц%", "%honorific%");
            //Regex.Replace(Utils.TranslitText(this.messageTextBox.Text, true), "#Ф(\\d)#", "#F$1#");
            this.SetMessage();
        }

        private void ContactsGridViewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                this.RemoveContact();
            }
        }

        private void GroupGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.RemoveGroup();
        }

        private void DeliveryGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.deliveryBindingSource.RemoveCurrent();
        }

        private void SendedGridViewRowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            try
            {
                var messagesList = new List<Message>();
                foreach (Message m in this.messagesBindingSource)
                {
                    var state = this.service.GetState(this.sessionId, m.MessageId);
                    m.Status = (int)state.State;
                    m.ReportedDate = state.ReportedDateUtc;
                    m.SubmittedDate = state.SubmittedDateUtc;
                    messagesList.Add(m);
                    this.db.UpdateMessage(m);
                }
                this.messagesBindingSource.DataSource = messagesList;
                this.sendedSource.DataSource = this.db.GetDeliveries();
            }
            catch
            {
            }

        }

        private void ContentDeliveryGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.contentDeliveryGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                var status = Int32.Parse(this.contentDeliveryGridView.Rows[e.RowIndex].Cells["Status"].Value.ToString());
                switch (status)
                {
                    case -1:
                        e.Value = "Отправлено";
                        break;
                    case -2:
                        e.Value = "В очереди";
                        break;
                    case -97:
                        e.Value = "Удалено";
                        break;
                    case -98:
                        e.Value = "Остановлено";
                        break;
                    case 0:
                        e.Value = "Доставлено";
                        break;
                    case 10:
                        e.Value = "Неверно введён адрес отправителя";
                        break;
                    case 11:
                        e.Value = "Неверно введён адрес получателя";
                        break;
                    case 41:
                        e.Value = "Недопустимый адрес получаателя";
                        break;
                    case 42:
                        e.Value = "Отклонено смс центром";
                        break;
                    case 46:
                        e.Value = "Отклонено";
                        break;
                    case 69:
                        e.Value = "Отклонено";
                        break;
                    case 99:
                        e.Value = "Неизвестный";
                        break;
                    case 255:
                        e.Value = "Неизвестный";
                        break;
                }
            }
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled && this.restartWorker)
            {
                this.restartWorker = false;
                this.backgroundWorker.RunWorkerAsync();
            }
        }

        private void SendedGridViewCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.GetMessages();
        }

        private void SendedGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetMessages();
        }

        private void GetMessages()
        {
            long id = ((Delivery)this.sendedSource.Current).Id;
            this.messagesBindingSource.DataSource = this.db.GetMessagesByDelivery(id);
            this.contentDeliveryGridView.DataSource = this.messagesBindingSource;
        }

        private void FilterButtonClick(object sender, EventArgs e)
        {
            DialogResult ok = this.filterForm.ShowDialog(this);
            if (ok == DialogResult.OK)
            {
                IEnumerable<Contact> contacts = this.db.GetContacts();
                if (contacts.Any())
                {
                    if (!string.IsNullOrEmpty(this.filterForm.FirstName))
                    {
                        contacts = contacts.Where(c => c.FirstName.Contains(this.filterForm.FirstName));
                    }
                    if (this.filterForm.Sex != 0)
                    {
                        contacts = contacts.Where(c => c.Sex == this.filterForm.Sex);
                    }
                    this.contactsBindingSource.DataSource = contacts;

                }
            }
            else if (ok == DialogResult.Abort)
            {
                this.LoadContacts();
            }
        }

        private void ExportCsvButtonClick(object sender, EventArgs e)
        {
            if (this.csvSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> list = this.db.ExportToCsv();
                File.WriteAllLines(this.csvSaveFileDialog.FileName, list.ToArray(), Encoding.GetEncoding(1251));
                MessageBox.Show(this, "Выгружено контактов: " + list.Count + ".");
            }
        }

        private void BackupButtonClick(object sender, EventArgs e)
        {
            Utils.BackupDatabase();
            MessageBox.Show("Резервная копия базы данных создана.");
        }

        private void ExploreButtonClick(object sender, EventArgs e)
        {
            Process.Start(@"Backup");
        }

        private void ImportCsvButtonClick(object sender, EventArgs e)
        {
            this.openFileDialog.FileName = "";
            this.openFileDialog.Filter = @"CSV (*.csv)|*.csv|Все файлы (*.*)|*.*";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var list = Utils.ImportFromCsv(this.openFileDialog.FileName);
                foreach (var contact in list)
                {
                    contact.Group.Id = (this.db.GetGroupIdByName(contact.Group.Name) ?? this.db.SaveGroup(contact.Group));
                    if (this.db.GetContactByPhone(contact.Phone) == null)
                    {
                        this.db.SaveContact(contact);
                    }
                }

                this.LoadContacts();
                this.LoadGroups();
                this.editGroupButton.Enabled = true;
                this.removeGroupButton.Enabled = true;
                this.editContactButton.Enabled = true;
                this.removeContactButton.Enabled = true;

                MessageBox.Show(@"Импорт данных завершен.", @"Импорт данных");
            }
        }

        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.SaveSettings();
        }
    }
}
