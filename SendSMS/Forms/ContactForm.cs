using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SendSMS.Data;
using SendSMS.Models;
using Group = SendSMS.Models.Group;

namespace SendSMS.Forms
{
    using System.ComponentModel;

    public partial class ContactForm : Form
    {
        private readonly DbManager db = new DbManager();
        public Contact Contact { get; set; }

        public bool EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }

        public override sealed string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        private bool editMode;

        public ContactForm(IEnumerable<Group> groups)
        {
            InitializeComponent();
            Text = @"Создать контакт";
            Contact = new Contact();
            var tmp = new List<Group>();
            tmp.AddRange(groups);
            tmp.RemoveAt(0);
            tmp.Insert(0, new Group{ Id = -1, Name = "Нет группы"});
            groupComboBox.DataSource = tmp;

        }
        public ContactForm(Contact contact, IEnumerable<Group> groups)
        {
            this.EditMode = true;
            InitializeComponent();
            Text = "Редактировать контакт";
            Contact = contact;
            var tmp = new List<Group>();
            tmp.AddRange(groups);
            tmp.RemoveAt(0);
            tmp.Insert(0, new Group { Id = -1, Name = "Нет группы" });
            groupComboBox.DataSource = tmp;
            LoadData();
        }

        private void LoadData()
        {
            groupComboBox.SelectedItem = Contact.Group;
            phoneTextBox.Text = Contact.Phone;
            lastNameTextBox.Text = Contact.LastName;
            firstNameTextBox.Text = Contact.FirstName;
            middleNameTextBox.Text = Contact.Patronymic;
            if (Contact.BirthdayDay > 0)
                dayTextBox.Text = Contact.BirthdayDay.ToString();
            if (Contact.BirthdayMonth > 0)
                monthTextBox.Text = Contact.BirthdayMonth.ToString();
            if (Contact.BirthdayYear > 0)
                yearTextBox.Text = Contact.BirthdayYear.ToString();

//            if (Contact.Birthday != null && Contact.Birthday > DateTime.MinValue)
//            {
//                birthdayPicker.Value = (DateTime)Contact.Birthday;
//                birthdayPicker.Checked = true;
//            }

            switch (Contact.Sex)
            {
                case 1:
                    maleRadioButton.Checked = true;
                    break;
                case 2:
                    femaleRadioButton.Checked = true;
                    break;
                default:
                    noSexRadioButton.Checked = true;
                    break;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (!EditMode && IsPhoneExist()) return;
            Contact.Group = (Group)groupComboBox.SelectedItem;
            Contact.LastName = lastNameTextBox.Text;
            Contact.FirstName = firstNameTextBox.Text;
            Contact.Patronymic = middleNameTextBox.Text;
            if (!string.IsNullOrEmpty(dayTextBox.Text))
                Contact.BirthdayDay = Int32.Parse(dayTextBox.Text);
            if (!string.IsNullOrEmpty(monthTextBox.Text))
                Contact.BirthdayMonth = Int32.Parse(monthTextBox.Text);
            if (!string.IsNullOrEmpty(yearTextBox.Text))
            Contact.BirthdayYear = Int32.Parse(yearTextBox.Text);

//            if (birthdayPicker.Checked)
//                Contact.Birthday = birthdayPicker.Value;
            Contact.Phone = phoneTextBox.Text; //Convert.ToInt64(Regex.Replace(this.phoneTextBox.Text, @"[\D]", ""));
            if (maleRadioButton.Checked)
                Contact.Sex = 1;
            else if (femaleRadioButton.Checked)
            {
                Contact.Sex = 2;
            }
            else
            {
                Contact.Sex = 0;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddContactFormLoad(object sender, EventArgs e)
        {
            groupComboBox.DisplayMember = "name";
        }

        private void PhoneTextBoxLeave(object sender, EventArgs e)
        {
            IsPhoneExist();
        }

        private bool IsPhoneExist()
        {
            bool exist = false;
            Contact contact = db.GetContactByPhone(phoneTextBox.Text);
            if (contact != null)
            {
                MessageBox.Show(this, "Контакт с таким номером телефона уже существует.\nФорма переключена на редактирование существующей анкеты.", @"Создать контакт");
                Contact = contact;
                LoadData();
                exist = true;
                editMode = true;
            }
            return exist;
        }

        private void DigitTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneTextBoxEnter(object sender, EventArgs e)
        {
            phoneTextBox.SelectionStart = 1;
        }

        private void ContactFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FirstNameTextBoxLeave(object sender, EventArgs e)
        {
            string maleNames = Properties.Resources.MaleNames;
            string femaleNames = Properties.Resources.FemaleNames;
            if (maleNames.Contains(firstNameTextBox.Text))
            {
                maleRadioButton.Checked = true;
            } else if(femaleNames.Contains(firstNameTextBox.Text))
            {
                femaleRadioButton.Checked = true;
            }
            else
            {
                noSexRadioButton.Checked = true;
            }
        }

        private void DateTextBoxLeave(object sender, EventArgs e)
        {
//            var textBox = ((TextBox)sender);
//            if(textBox.Name.Equals("dayTextBox") && Int32.Parse(textBox.Text) > 31)
//            {
//                dayTextBox.Text = "31";
//            }
//            else if (textBox.Name.Equals("monthTextBox") && Int32.Parse(textBox.Text) > 12)
//            {
//                monthTextBox.Text = "12";
//            }
//            if (dayTextBox.Text != "")
//            dayTextBox.Text = DateTime.DaysInMonth(DateTime.Now.Year, Int32.Parse(textBox.Text)).ToString();
        }
    }
}
