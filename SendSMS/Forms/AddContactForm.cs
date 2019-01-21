using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SendSMS.Data;
using SendSMS.Models;

namespace SendSMS.Forms
{
    public partial class AddContactForm : Form
    {
        private readonly DbManager db;
        public List<Contact> Contacts { get; set; }
        public AddContactForm()
        {
            InitializeComponent();
            db = new DbManager();
            groupBindingSource.DataSource = db.GetGroups();
            groupComboBox.DataSource = groupBindingSource;
            contactsBindingSource.DataSource = db.GetContactsByGroup(((Group)groupBindingSource.Current).Id);
            contactGridView.DataSource = contactsBindingSource;
            Contacts = new List<Contact>();
        }
        
        private void AddButtonClick(object sender, EventArgs e)
        {
            if (contactRadioButton.Checked)
            {
                Contacts.Add((Contact)contactsBindingSource.Current);
            } else if (groupRadioButton.Checked)
            {
                Contacts = (List<Contact>)contactsBindingSource.DataSource;
            }
//            DialogResult = DialogResult.OK;
//            Close();
        }

        private void GroupComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBindingSource.Current != null)
            {
                contactsBindingSource.DataSource = db.GetContactsByGroup(((Group)groupComboBox.SelectedItem).Id);
                contactGridView.DataSource = contactsBindingSource;

            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
