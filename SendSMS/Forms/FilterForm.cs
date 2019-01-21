using System;
using System.Windows.Forms;

namespace SendSMS.Forms
{
    public partial class FilterForm : Form
    {
        public int Sex { get; set; }
        public string FirstName { get; set; }
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                FirstName = firstNameTextBox.Text;
            }

            if (maleRadioButton.Checked)
            {
                Sex = 1;
            }
            else if (femaleRadioButton.Checked)
            {
                Sex = 2;
            }
            else if (allSexRadioButton.Checked)
            {
                Sex = 0;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            allSexRadioButton.Checked = true;
            firstNameTextBox.Text = "";
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
