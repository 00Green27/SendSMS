namespace SendSMS.Forms
{
    partial class AddContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.contactRadioButton = new System.Windows.Forms.RadioButton();
            this.contactGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactBirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactBirthdayDayYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группа:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComboBox.DisplayMember = "name";
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(156, 6);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(287, 21);
            this.groupComboBox.TabIndex = 1;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBoxSelectedIndexChanged);
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.AutoSize = true;
            this.groupRadioButton.Checked = true;
            this.groupRadioButton.Location = new System.Drawing.Point(87, 33);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(124, 17);
            this.groupRadioButton.TabIndex = 2;
            this.groupRadioButton.TabStop = true;
            this.groupRadioButton.Text = "Все номера группы";
            this.groupRadioButton.UseVisualStyleBackColor = true;
            // 
            // contactRadioButton
            // 
            this.contactRadioButton.AutoSize = true;
            this.contactRadioButton.Location = new System.Drawing.Point(87, 56);
            this.contactRadioButton.Name = "contactRadioButton";
            this.contactRadioButton.Size = new System.Drawing.Size(104, 17);
            this.contactRadioButton.TabIndex = 3;
            this.contactRadioButton.Text = "Выбрать номер";
            this.contactRadioButton.UseVisualStyleBackColor = true;
            // 
            // contactGridView
            // 
            this.contactGridView.AllowUserToAddRows = false;
            this.contactGridView.AllowUserToDeleteRows = false;
            this.contactGridView.AllowUserToResizeColumns = false;
            this.contactGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contactGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contactGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.contactGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contactGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phone,
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Group,
            this.sex,
            this.birthday,
            this.message,
            this.messageId,
            this.Id,
            this.ContactBirthDay,
            this.ContactBirthYear,
            this.ContactBirthdayDayYear});
            this.contactGridView.Location = new System.Drawing.Point(12, 79);
            this.contactGridView.MultiSelect = false;
            this.contactGridView.Name = "contactGridView";
            this.contactGridView.ReadOnly = true;
            this.contactGridView.RowHeadersVisible = false;
            this.contactGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactGridView.Size = new System.Drawing.Size(431, 220);
            this.contactGridView.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(287, 305);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(368, 305);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phone";
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "lastname";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "firstname";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "patronymic";
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "group";
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Visible = false;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "sex";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Visible = false;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Visible = false;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Visible = false;
            // 
            // messageId
            // 
            this.messageId.DataPropertyName = "messageId";
            this.messageId.HeaderText = "messageId";
            this.messageId.Name = "messageId";
            this.messageId.ReadOnly = true;
            this.messageId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ContactBirthDay
            // 
            this.ContactBirthDay.DataPropertyName = "BirthdayDay";
            this.ContactBirthDay.HeaderText = "ContactBirthDay";
            this.ContactBirthDay.Name = "ContactBirthDay";
            this.ContactBirthDay.ReadOnly = true;
            this.ContactBirthDay.Visible = false;
            // 
            // ContactBirthYear
            // 
            this.ContactBirthYear.DataPropertyName = "BirthdayMonth";
            this.ContactBirthYear.HeaderText = "ContactBirthMonth";
            this.ContactBirthYear.Name = "ContactBirthYear";
            this.ContactBirthYear.ReadOnly = true;
            this.ContactBirthYear.Visible = false;
            // 
            // ContactBirthdayDayYear
            // 
            this.ContactBirthdayDayYear.DataPropertyName = "BirthdayYear";
            this.ContactBirthdayDayYear.HeaderText = "BirthdayDayYear";
            this.ContactBirthdayDayYear.Name = "ContactBirthdayDayYear";
            this.ContactBirthdayDayYear.ReadOnly = true;
            this.ContactBirthdayDayYear.Visible = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 340);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contactGridView);
            this.Controls.Add(this.contactRadioButton);
            this.Controls.Add(this.groupRadioButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить номера";
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.RadioButton groupRadioButton;
        private System.Windows.Forms.RadioButton contactRadioButton;
        private System.Windows.Forms.DataGridView contactGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactBirthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactBirthdayDayYear;
    }
}