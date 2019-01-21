using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SendSMS.Models;

namespace SendSMS.Forms
{
    using System.Linq;

    public partial class GroupForm : Form
    {
        private readonly List<Group> groups;

        public Group Group { get; set; }

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

        public GroupForm(List<Group> groups)
        {
            InitializeComponent();
            Text = @"Создать группу";
            Group = new Group();
            this.groups = groups;
        }

        public GroupForm(Group group, List<Group> groups)
        {
            InitializeComponent();
            Text = @"Редактировать группу";
            Group = group;
            nameTextBox.Text = group.Name;
            this.groups = groups;

        }


        private void OkButtonClick(object sender, EventArgs e)
        {
            if (this.groups.Any(@group => @group.Name == this.nameTextBox.Text))
            {
                MessageBox.Show(this, @"Группа с таким названием уже существует.", @"Создать группу");
                return;
            }
            Group.Name = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void GroupFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
