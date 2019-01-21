namespace SendSMS.Forms
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addressBookPage = new System.Windows.Forms.TabPage();
            this.contactsGridView = new System.Windows.Forms.DataGridView();
            this.SexImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsToolStrip = new System.Windows.Forms.ToolStrip();
            this.addContactButton = new System.Windows.Forms.ToolStripButton();
            this.editContactButton = new System.Windows.Forms.ToolStripButton();
            this.removeContactButton = new System.Windows.Forms.ToolStripButton();
            this.addToDeliveryButton = new System.Windows.Forms.ToolStripButton();
            this.filterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importDumpButton = new System.Windows.Forms.ToolStripButton();
            this.importCSVButton = new System.Windows.Forms.ToolStripButton();
            this.exportCSVButton = new System.Windows.Forms.ToolStripButton();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.addGroupButton = new System.Windows.Forms.ToolStripButton();
            this.editGroupButton = new System.Windows.Forms.ToolStripButton();
            this.removeGroupButton = new System.Windows.Forms.ToolStripButton();
            this.createDeliveryPage = new System.Windows.Forms.TabPage();
            this.translitCheckBox = new System.Windows.Forms.CheckBox();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.deliveryGridView = new System.Windows.Forms.DataGridView();
            this.deliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBirthdayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBirtdayMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBirtdayYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryMessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverySex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryBirthDayYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryBirthDayMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.addNumbersButton = new System.Windows.Forms.ToolStripButton();
            this.removeNumberButton = new System.Windows.Forms.ToolStripButton();
            this.deliveryStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lablesButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.firstnameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastnameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronymicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honorificMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSymbolsLabel = new System.Windows.Forms.ToolStripLabel();
            this.label = new System.Windows.Forms.Label();
            this.deliveryNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryPage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sendedGridView = new System.Windows.Forms.DataGridView();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendedSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentDeliveryGridView = new System.Windows.Forms.DataGridView();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentMessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.optionsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backupButton = new System.Windows.Forms.Button();
            this.exploreButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.proxyPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.proxyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.proxyLoginTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.proxyPasswordLabel = new System.Windows.Forms.Label();
            this.proxyLoginLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.authButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.statusLabel = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csvSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.addressBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.contactsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            this.groupToolStrip.SuspendLayout();
            this.createDeliveryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGridView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.deliveryPage.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendedSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentDeliveryGridView)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.proxyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addressBookPage);
            this.tabControl.Controls.Add(this.createDeliveryPage);
            this.tabControl.Controls.Add(this.deliveryPage);
            this.tabControl.Controls.Add(this.optionsPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList;
            this.tabControl.Location = new System.Drawing.Point(0, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 469);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // addressBookPage
            // 
            this.addressBookPage.Controls.Add(this.contactsGridView);
            this.addressBookPage.Controls.Add(this.contactsToolStrip);
            this.addressBookPage.Controls.Add(this.groupGridView);
            this.addressBookPage.Controls.Add(this.groupToolStrip);
            this.addressBookPage.ImageIndex = 0;
            this.addressBookPage.Location = new System.Drawing.Point(4, 23);
            this.addressBookPage.Name = "addressBookPage";
            this.addressBookPage.Padding = new System.Windows.Forms.Padding(3);
            this.addressBookPage.Size = new System.Drawing.Size(776, 442);
            this.addressBookPage.TabIndex = 0;
            this.addressBookPage.Text = "Адресная книга";
            this.addressBookPage.UseVisualStyleBackColor = true;
            // 
            // contactsGridView
            // 
            this.contactsGridView.AllowUserToAddRows = false;
            this.contactsGridView.AllowUserToDeleteRows = false;
            this.contactsGridView.AllowUserToResizeColumns = false;
            this.contactsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contactsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contactsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsGridView.AutoGenerateColumns = false;
            this.contactsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.contactsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contactsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SexImage,
            this.Phone,
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Sex,
            this.Group,
            this.ContactId,
            this.BirthdayDay,
            this.BirthdayMonth,
            this.BirthdayYear,
            this.Birthday,
            this.Message,
            this.MessageId});
            this.contactsGridView.DataSource = this.contactsBindingSource;
            this.contactsGridView.Location = new System.Drawing.Point(191, 31);
            this.contactsGridView.Name = "contactsGridView";
            this.contactsGridView.ReadOnly = true;
            this.contactsGridView.RowHeadersVisible = false;
            this.contactsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsGridView.Size = new System.Drawing.Size(579, 403);
            this.contactsGridView.TabIndex = 7;
            this.contactsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditContactButtonClick);
            this.contactsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ContactsGridViewCellFormatting);
            this.contactsGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactsGridViewKeyDown);
            // 
            // SexImage
            // 
            this.SexImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SexImage.HeaderText = "Пол";
            this.SexImage.Name = "SexImage";
            this.SexImage.ReadOnly = true;
            this.SexImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SexImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SexImage.Width = 35;
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
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Visible = false;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Visible = false;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "id";
            this.ContactId.HeaderText = "ContactId";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // BirthdayDay
            // 
            this.BirthdayDay.DataPropertyName = "BirthdayDay";
            this.BirthdayDay.HeaderText = "BirthdayDay";
            this.BirthdayDay.Name = "BirthdayDay";
            this.BirthdayDay.ReadOnly = true;
            this.BirthdayDay.Visible = false;
            // 
            // BirthdayMonth
            // 
            this.BirthdayMonth.DataPropertyName = "BirthdayMonth";
            this.BirthdayMonth.HeaderText = "BirthdayMonth";
            this.BirthdayMonth.Name = "BirthdayMonth";
            this.BirthdayMonth.ReadOnly = true;
            this.BirthdayMonth.Visible = false;
            // 
            // BirthdayYear
            // 
            this.BirthdayYear.DataPropertyName = "BirthdayYear";
            this.BirthdayYear.HeaderText = "BirthdayYear";
            this.BirthdayYear.Name = "BirthdayYear";
            this.BirthdayYear.ReadOnly = true;
            this.BirthdayYear.Visible = false;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Visible = false;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Visible = false;
            // 
            // MessageId
            // 
            this.MessageId.DataPropertyName = "MessageId";
            this.MessageId.HeaderText = "MessageId";
            this.MessageId.Name = "MessageId";
            this.MessageId.ReadOnly = true;
            this.MessageId.Visible = false;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.Filter = "";
            // 
            // contactsToolStrip
            // 
            this.contactsToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsToolStrip.AutoSize = false;
            this.contactsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.contactsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contactsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactButton,
            this.editContactButton,
            this.removeContactButton,
            this.addToDeliveryButton,
            this.filterButton,
            this.toolStripSeparator1,
            this.importDumpButton,
            this.importCSVButton,
            this.exportCSVButton});
            this.contactsToolStrip.Location = new System.Drawing.Point(191, 3);
            this.contactsToolStrip.Name = "contactsToolStrip";
            this.contactsToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.contactsToolStrip.Size = new System.Drawing.Size(579, 25);
            this.contactsToolStrip.TabIndex = 6;
            this.contactsToolStrip.Text = "toolStrip2";
            // 
            // addContactButton
            // 
            this.addContactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addContactButton.Image = ((System.Drawing.Image)(resources.GetObject("addContactButton.Image")));
            this.addContactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(23, 22);
            this.addContactButton.Text = "Добавить контакт";
            this.addContactButton.Click += new System.EventHandler(this.AddContactButtonClick);
            // 
            // editContactButton
            // 
            this.editContactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editContactButton.Image = ((System.Drawing.Image)(resources.GetObject("editContactButton.Image")));
            this.editContactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(23, 22);
            this.editContactButton.Text = "Редактировать контакт";
            this.editContactButton.Click += new System.EventHandler(this.EditContactButtonClick);
            // 
            // removeContactButton
            // 
            this.removeContactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeContactButton.Image = ((System.Drawing.Image)(resources.GetObject("removeContactButton.Image")));
            this.removeContactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(23, 22);
            this.removeContactButton.Text = "Удалить контакт";
            this.removeContactButton.Click += new System.EventHandler(this.RemoveContactButtonClick);
            // 
            // addToDeliveryButton
            // 
            this.addToDeliveryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToDeliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("addToDeliveryButton.Image")));
            this.addToDeliveryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToDeliveryButton.Name = "addToDeliveryButton";
            this.addToDeliveryButton.Size = new System.Drawing.Size(23, 22);
            this.addToDeliveryButton.Text = "Добавить выделенные номера в новую рассылку";
            this.addToDeliveryButton.Click += new System.EventHandler(this.AddToDeliveryButtonClick);
            // 
            // filterButton
            // 
            this.filterButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.filterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(23, 22);
            this.filterButton.Text = "Фильтр";
            this.filterButton.Click += new System.EventHandler(this.FilterButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // importDumpButton
            // 
            this.importDumpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importDumpButton.Image = ((System.Drawing.Image)(resources.GetObject("importDumpButton.Image")));
            this.importDumpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importDumpButton.Name = "importDumpButton";
            this.importDumpButton.Size = new System.Drawing.Size(23, 22);
            this.importDumpButton.Text = "Импорт из дампа";
            this.importDumpButton.Click += new System.EventHandler(this.ImportDumpButtonClick);
            // 
            // importCSVButton
            // 
            this.importCSVButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importCSVButton.Image = ((System.Drawing.Image)(resources.GetObject("importCSVButton.Image")));
            this.importCSVButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importCSVButton.Name = "importCSVButton";
            this.importCSVButton.Size = new System.Drawing.Size(23, 22);
            this.importCSVButton.Text = "Импорт из CSV файла";
            this.importCSVButton.Click += new System.EventHandler(this.ImportCsvButtonClick);
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportCSVButton.Image = ((System.Drawing.Image)(resources.GetObject("exportCSVButton.Image")));
            this.exportCSVButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(23, 22);
            this.exportCSVButton.Text = "Экспорт в CSV файл";
            this.exportCSVButton.Click += new System.EventHandler(this.ExportCsvButtonClick);
            // 
            // groupGridView
            // 
            this.groupGridView.AllowUserToAddRows = false;
            this.groupGridView.AllowUserToDeleteRows = false;
            this.groupGridView.AllowUserToResizeColumns = false;
            this.groupGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.groupGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.groupGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.ColumnHeadersVisible = false;
            this.groupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupName,
            this.GroupCount});
            this.groupGridView.Location = new System.Drawing.Point(5, 31);
            this.groupGridView.MultiSelect = false;
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.ReadOnly = true;
            this.groupGridView.RowHeadersVisible = false;
            this.groupGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupGridView.Size = new System.Drawing.Size(180, 403);
            this.groupGridView.TabIndex = 5;
            this.groupGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupGridViewCellClick);
            this.groupGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupGridViewCellDoubleClick);
            this.groupGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupGridViewCellEnter);
            this.groupGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GroupGridViewKeyDown);
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "id";
            this.GroupId.HeaderText = "id";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "name";
            this.GroupName.HeaderText = "Группа";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // GroupCount
            // 
            this.GroupCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GroupCount.DataPropertyName = "count";
            this.GroupCount.HeaderText = "";
            this.GroupCount.Name = "GroupCount";
            this.GroupCount.ReadOnly = true;
            this.GroupCount.Width = 20;
            // 
            // groupToolStrip
            // 
            this.groupToolStrip.AutoSize = false;
            this.groupToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.groupToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.groupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.addGroupButton,
            this.editGroupButton,
            this.removeGroupButton});
            this.groupToolStrip.Location = new System.Drawing.Point(5, 3);
            this.groupToolStrip.Name = "groupToolStrip";
            this.groupToolStrip.Size = new System.Drawing.Size(180, 25);
            this.groupToolStrip.TabIndex = 4;
            this.groupToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Группы";
            // 
            // addGroupButton
            // 
            this.addGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("addGroupButton.Image")));
            this.addGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(23, 22);
            this.addGroupButton.Text = "Добавить группу";
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButtonClick);
            // 
            // editGroupButton
            // 
            this.editGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editGroupButton.Enabled = false;
            this.editGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("editGroupButton.Image")));
            this.editGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(23, 22);
            this.editGroupButton.Text = "Редактировать группу";
            this.editGroupButton.Click += new System.EventHandler(this.EditGroupButtonClick);
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeGroupButton.Enabled = false;
            this.removeGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("removeGroupButton.Image")));
            this.removeGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(23, 22);
            this.removeGroupButton.Text = "Удалить группу";
            this.removeGroupButton.Click += new System.EventHandler(this.RemoveGroupButtonClick);
            // 
            // createDeliveryPage
            // 
            this.createDeliveryPage.Controls.Add(this.translitCheckBox);
            this.createDeliveryPage.Controls.Add(this.deliveryButton);
            this.createDeliveryPage.Controls.Add(this.deliveryGridView);
            this.createDeliveryPage.Controls.Add(this.toolStrip3);
            this.createDeliveryPage.Controls.Add(this.messageTextBox);
            this.createDeliveryPage.Controls.Add(this.toolStrip2);
            this.createDeliveryPage.Controls.Add(this.label);
            this.createDeliveryPage.Controls.Add(this.deliveryNameTextBox);
            this.createDeliveryPage.ImageIndex = 1;
            this.createDeliveryPage.Location = new System.Drawing.Point(4, 23);
            this.createDeliveryPage.Name = "createDeliveryPage";
            this.createDeliveryPage.Padding = new System.Windows.Forms.Padding(3);
            this.createDeliveryPage.Size = new System.Drawing.Size(776, 442);
            this.createDeliveryPage.TabIndex = 2;
            this.createDeliveryPage.Text = "Создать рассылку";
            this.createDeliveryPage.UseVisualStyleBackColor = true;
            // 
            // translitCheckBox
            // 
            this.translitCheckBox.AutoSize = true;
            this.translitCheckBox.Location = new System.Drawing.Point(8, 238);
            this.translitCheckBox.Name = "translitCheckBox";
            this.translitCheckBox.Size = new System.Drawing.Size(147, 17);
            this.translitCheckBox.TabIndex = 10;
            this.translitCheckBox.Text = "Сообщение транслитом";
            this.translitCheckBox.UseVisualStyleBackColor = true;
            this.translitCheckBox.CheckedChanged += new System.EventHandler(this.TranslitCheckBoxCheckedChanged);
            // 
            // deliveryButton
            // 
            this.deliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("deliveryButton.Image")));
            this.deliveryButton.Location = new System.Drawing.Point(628, 411);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(140, 23);
            this.deliveryButton.TabIndex = 9;
            this.deliveryButton.Text = "Создать рассылку";
            this.deliveryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deliveryButton.UseVisualStyleBackColor = true;
            this.deliveryButton.Click += new System.EventHandler(this.DeliveryButtonClick);
            // 
            // deliveryGridView
            // 
            this.deliveryGridView.AllowUserToAddRows = false;
            this.deliveryGridView.AllowUserToDeleteRows = false;
            this.deliveryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deliveryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.deliveryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deliveryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deliveryGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.deliveryGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deliveryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.deliveryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryId,
            this.deliveryBirthdayDay,
            this.deliveryBirtdayMonth,
            this.deliveryBirtdayYear,
            this.DeliveryMessageId,
            this.deliveryPatronymic,
            this.deliveryLastname,
            this.deliveryFirstname,
            this.deliverySex,
            this.deliveryBirthday,
            this.DeliveryBirthDayYear,
            this.DeliveryBirthDayMonth,
            this.deliveryGroup,
            this.deliveryPhone,
            this.deliveryMessage});
            this.deliveryGridView.Location = new System.Drawing.Point(298, 36);
            this.deliveryGridView.MultiSelect = false;
            this.deliveryGridView.Name = "deliveryGridView";
            this.deliveryGridView.ReadOnly = true;
            this.deliveryGridView.RowHeadersVisible = false;
            this.deliveryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deliveryGridView.Size = new System.Drawing.Size(470, 371);
            this.deliveryGridView.TabIndex = 8;
            this.deliveryGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.RemoveContactsButtonCheck);
            this.deliveryGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.RemoveContactsButtonCheck);
            this.deliveryGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeliveryGridViewKeyDown);
            // 
            // deliveryId
            // 
            this.deliveryId.DataPropertyName = "id";
            this.deliveryId.HeaderText = "deliveryId";
            this.deliveryId.Name = "deliveryId";
            this.deliveryId.ReadOnly = true;
            this.deliveryId.Visible = false;
            // 
            // deliveryBirthdayDay
            // 
            this.deliveryBirthdayDay.DataPropertyName = "BirthdayDay";
            this.deliveryBirthdayDay.HeaderText = "BirthdayDay";
            this.deliveryBirthdayDay.Name = "deliveryBirthdayDay";
            this.deliveryBirthdayDay.ReadOnly = true;
            this.deliveryBirthdayDay.Visible = false;
            // 
            // deliveryBirtdayMonth
            // 
            this.deliveryBirtdayMonth.DataPropertyName = "BirtdayMonth";
            this.deliveryBirtdayMonth.HeaderText = "BirtdayMonth";
            this.deliveryBirtdayMonth.Name = "deliveryBirtdayMonth";
            this.deliveryBirtdayMonth.ReadOnly = true;
            this.deliveryBirtdayMonth.Visible = false;
            // 
            // deliveryBirtdayYear
            // 
            this.deliveryBirtdayYear.DataPropertyName = "birtdayYear";
            this.deliveryBirtdayYear.HeaderText = "BirtdayYear";
            this.deliveryBirtdayYear.Name = "deliveryBirtdayYear";
            this.deliveryBirtdayYear.ReadOnly = true;
            this.deliveryBirtdayYear.Visible = false;
            // 
            // DeliveryMessageId
            // 
            this.DeliveryMessageId.DataPropertyName = "MessageId";
            this.DeliveryMessageId.HeaderText = "DeliveryMessageId";
            this.DeliveryMessageId.Name = "DeliveryMessageId";
            this.DeliveryMessageId.ReadOnly = true;
            this.DeliveryMessageId.Visible = false;
            // 
            // deliveryPatronymic
            // 
            this.deliveryPatronymic.DataPropertyName = "patronymic";
            this.deliveryPatronymic.HeaderText = "deliveryPatronymic";
            this.deliveryPatronymic.Name = "deliveryPatronymic";
            this.deliveryPatronymic.ReadOnly = true;
            this.deliveryPatronymic.Visible = false;
            // 
            // deliveryLastname
            // 
            this.deliveryLastname.DataPropertyName = "firstname";
            this.deliveryLastname.HeaderText = "deliveryLastname";
            this.deliveryLastname.Name = "deliveryLastname";
            this.deliveryLastname.ReadOnly = true;
            this.deliveryLastname.Visible = false;
            // 
            // deliveryFirstname
            // 
            this.deliveryFirstname.DataPropertyName = "lastname";
            this.deliveryFirstname.HeaderText = "deliveryFirstname";
            this.deliveryFirstname.Name = "deliveryFirstname";
            this.deliveryFirstname.ReadOnly = true;
            this.deliveryFirstname.Visible = false;
            // 
            // deliverySex
            // 
            this.deliverySex.DataPropertyName = "sex";
            this.deliverySex.HeaderText = "deliverySex";
            this.deliverySex.Name = "deliverySex";
            this.deliverySex.ReadOnly = true;
            this.deliverySex.Visible = false;
            // 
            // deliveryBirthday
            // 
            this.deliveryBirthday.DataPropertyName = "BirthDay";
            this.deliveryBirthday.HeaderText = "deliveryBirthday";
            this.deliveryBirthday.Name = "deliveryBirthday";
            this.deliveryBirthday.ReadOnly = true;
            this.deliveryBirthday.Visible = false;
            // 
            // DeliveryBirthDayYear
            // 
            this.DeliveryBirthDayYear.DataPropertyName = "BirthDayYear";
            this.DeliveryBirthDayYear.HeaderText = "DeliveryBirthDayYear";
            this.DeliveryBirthDayYear.Name = "DeliveryBirthDayYear";
            this.DeliveryBirthDayYear.ReadOnly = true;
            this.DeliveryBirthDayYear.Visible = false;
            // 
            // DeliveryBirthDayMonth
            // 
            this.DeliveryBirthDayMonth.DataPropertyName = "BirthDayMonth";
            this.DeliveryBirthDayMonth.HeaderText = "DeliveryBirthDayMonth";
            this.DeliveryBirthDayMonth.Name = "DeliveryBirthDayMonth";
            this.DeliveryBirthDayMonth.ReadOnly = true;
            this.DeliveryBirthDayMonth.Visible = false;
            // 
            // deliveryGroup
            // 
            this.deliveryGroup.DataPropertyName = "Group";
            this.deliveryGroup.HeaderText = "deliveryGroup";
            this.deliveryGroup.Name = "deliveryGroup";
            this.deliveryGroup.ReadOnly = true;
            this.deliveryGroup.Visible = false;
            // 
            // deliveryPhone
            // 
            this.deliveryPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deliveryPhone.DataPropertyName = "phone";
            this.deliveryPhone.HeaderText = "Телефон";
            this.deliveryPhone.Name = "deliveryPhone";
            this.deliveryPhone.ReadOnly = true;
            this.deliveryPhone.Width = 77;
            // 
            // deliveryMessage
            // 
            this.deliveryMessage.DataPropertyName = "Message";
            this.deliveryMessage.HeaderText = "Сообщение";
            this.deliveryMessage.Name = "deliveryMessage";
            this.deliveryMessage.ReadOnly = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.addNumbersButton,
            this.removeNumberButton,
            this.deliveryStatusLabel});
            this.toolStrip3.Location = new System.Drawing.Point(298, 8);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(470, 25);
            this.toolStrip3.TabIndex = 7;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "Получатели";
            // 
            // addNumbersButton
            // 
            this.addNumbersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNumbersButton.Image = ((System.Drawing.Image)(resources.GetObject("addNumbersButton.Image")));
            this.addNumbersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNumbersButton.Name = "addNumbersButton";
            this.addNumbersButton.Size = new System.Drawing.Size(23, 22);
            this.addNumbersButton.Text = "Добавить группу номеров";
            this.addNumbersButton.Click += new System.EventHandler(this.AddNumbersButtonClick);
            // 
            // removeNumberButton
            // 
            this.removeNumberButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeNumberButton.Image = ((System.Drawing.Image)(resources.GetObject("removeNumberButton.Image")));
            this.removeNumberButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeNumberButton.Name = "removeNumberButton";
            this.removeNumberButton.Size = new System.Drawing.Size(23, 22);
            this.removeNumberButton.Text = "Удалить номер";
            this.removeNumberButton.Click += new System.EventHandler(this.RemoveNumberButtonClick);
            // 
            // deliveryStatusLabel
            // 
            this.deliveryStatusLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deliveryStatusLabel.Name = "deliveryStatusLabel";
            this.deliveryStatusLabel.Size = new System.Drawing.Size(158, 22);
            this.deliveryStatusLabel.Text = "Количество получателей: 0";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(8, 68);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(281, 164);
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.TextChanged += new System.EventHandler(this.MessageTextBoxTextChanged);
            this.messageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageTextBoxKeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lablesButton,
            this.countSymbolsLabel});
            this.toolStrip2.Location = new System.Drawing.Point(8, 40);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(281, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lablesButton
            // 
            this.lablesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstnameMenuItem,
            this.lastnameMenuItem,
            this.patronymicMenuItem,
            this.honorificMenuItem});
            this.lablesButton.Image = ((System.Drawing.Image)(resources.GetObject("lablesButton.Image")));
            this.lablesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lablesButton.Name = "lablesButton";
            this.lablesButton.Size = new System.Drawing.Size(71, 22);
            this.lablesButton.Text = "Метки";
            // 
            // firstnameMenuItem
            // 
            this.firstnameMenuItem.Name = "firstnameMenuItem";
            this.firstnameMenuItem.Size = new System.Drawing.Size(140, 22);
            this.firstnameMenuItem.Text = "Имя";
            this.firstnameMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // lastnameMenuItem
            // 
            this.lastnameMenuItem.Name = "lastnameMenuItem";
            this.lastnameMenuItem.Size = new System.Drawing.Size(140, 22);
            this.lastnameMenuItem.Text = "Фамилия";
            this.lastnameMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // patronymicMenuItem
            // 
            this.patronymicMenuItem.Name = "patronymicMenuItem";
            this.patronymicMenuItem.Size = new System.Drawing.Size(140, 22);
            this.patronymicMenuItem.Text = "Отчество";
            this.patronymicMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // honorificMenuItem
            // 
            this.honorificMenuItem.Name = "honorificMenuItem";
            this.honorificMenuItem.Size = new System.Drawing.Size(140, 22);
            this.honorificMenuItem.Text = "Обращение";
            this.honorificMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // countSymbolsLabel
            // 
            this.countSymbolsLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.countSymbolsLabel.Name = "countSymbolsLabel";
            this.countSymbolsLabel.Size = new System.Drawing.Size(114, 22);
            this.countSymbolsLabel.Text = "0 символов / 0 SMS";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Название:";
            // 
            // deliveryNameTextBox
            // 
            this.deliveryNameTextBox.Location = new System.Drawing.Point(110, 17);
            this.deliveryNameTextBox.Name = "deliveryNameTextBox";
            this.deliveryNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.deliveryNameTextBox.TabIndex = 0;
            // 
            // deliveryPage
            // 
            this.deliveryPage.Controls.Add(this.splitContainer);
            this.deliveryPage.ImageIndex = 2;
            this.deliveryPage.Location = new System.Drawing.Point(4, 23);
            this.deliveryPage.Name = "deliveryPage";
            this.deliveryPage.Padding = new System.Windows.Forms.Padding(3);
            this.deliveryPage.Size = new System.Drawing.Size(776, 442);
            this.deliveryPage.TabIndex = 1;
            this.deliveryPage.Text = "Рассылки";
            this.deliveryPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sendedGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.contentDeliveryGridView);
            this.splitContainer.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer.Size = new System.Drawing.Size(770, 436);
            this.splitContainer.SplitterDistance = 218;
            this.splitContainer.TabIndex = 2;
            // 
            // sendedGridView
            // 
            this.sendedGridView.AllowUserToAddRows = false;
            this.sendedGridView.AllowUserToDeleteRows = false;
            this.sendedGridView.AllowUserToResizeColumns = false;
            this.sendedGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sendedGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sendedGridView.AutoGenerateColumns = false;
            this.sendedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sendedGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sendedGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sendedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sendedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedDate,
            this.DeliveryName,
            this.SendedStatus,
            this.ShipedStatus,
            this.DeliveryId1});
            this.sendedGridView.DataSource = this.sendedSource;
            this.sendedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendedGridView.Location = new System.Drawing.Point(0, 0);
            this.sendedGridView.MultiSelect = false;
            this.sendedGridView.Name = "sendedGridView";
            this.sendedGridView.ReadOnly = true;
            this.sendedGridView.RowHeadersVisible = false;
            this.sendedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sendedGridView.Size = new System.Drawing.Size(770, 218);
            this.sendedGridView.TabIndex = 0;
            this.sendedGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SendedGridViewCellClick);
            this.sendedGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SendedGridViewCellEnter);
            this.sendedGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SendedGridViewRowEnter);
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "createdDate";
            this.CreatedDate.HeaderText = "Дата создания";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // DeliveryName
            // 
            this.DeliveryName.DataPropertyName = "name";
            this.DeliveryName.HeaderText = "Название";
            this.DeliveryName.Name = "DeliveryName";
            this.DeliveryName.ReadOnly = true;
            // 
            // SendedStatus
            // 
            this.SendedStatus.DataPropertyName = "sent";
            this.SendedStatus.HeaderText = "Отправлено";
            this.SendedStatus.Name = "SendedStatus";
            this.SendedStatus.ReadOnly = true;
            // 
            // ShipedStatus
            // 
            this.ShipedStatus.DataPropertyName = "delivered";
            this.ShipedStatus.HeaderText = "Доставлено";
            this.ShipedStatus.Name = "ShipedStatus";
            this.ShipedStatus.ReadOnly = true;
            // 
            // DeliveryId1
            // 
            this.DeliveryId1.DataPropertyName = "id";
            this.DeliveryId1.HeaderText = "DeliveryId1";
            this.DeliveryId1.Name = "DeliveryId1";
            this.DeliveryId1.ReadOnly = true;
            this.DeliveryId1.Visible = false;
            // 
            // contentDeliveryGridView
            // 
            this.contentDeliveryGridView.AllowUserToAddRows = false;
            this.contentDeliveryGridView.AllowUserToDeleteRows = false;
            this.contentDeliveryGridView.AllowUserToResizeColumns = false;
            this.contentDeliveryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contentDeliveryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.contentDeliveryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contentDeliveryGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.contentDeliveryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contentDeliveryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentDeliveryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SendDate,
            this.ReportedDate,
            this.PhoneNumber,
            this.Status,
            this.SMS,
            this.ContentId,
            this.ContentMessageId,
            this.ContentDeliveryId,
            this.ContentContactId});
            this.contentDeliveryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentDeliveryGridView.Location = new System.Drawing.Point(0, 25);
            this.contentDeliveryGridView.MultiSelect = false;
            this.contentDeliveryGridView.Name = "contentDeliveryGridView";
            this.contentDeliveryGridView.ReadOnly = true;
            this.contentDeliveryGridView.RowHeadersVisible = false;
            this.contentDeliveryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentDeliveryGridView.Size = new System.Drawing.Size(770, 189);
            this.contentDeliveryGridView.TabIndex = 3;
            this.contentDeliveryGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ContentDeliveryGridViewCellFormatting);
            // 
            // SendDate
            // 
            this.SendDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SendDate.DataPropertyName = "SubmittedDate";
            this.SendDate.HeaderText = "Дата отправки";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            this.SendDate.Width = 130;
            // 
            // ReportedDate
            // 
            this.ReportedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReportedDate.DataPropertyName = "ReportedDate";
            this.ReportedDate.HeaderText = "Дата доставки";
            this.ReportedDate.Name = "ReportedDate";
            this.ReportedDate.ReadOnly = true;
            this.ReportedDate.Width = 110;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "Phone";
            this.PhoneNumber.HeaderText = "Номер получателя";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // SMS
            // 
            this.SMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SMS.DataPropertyName = "Text";
            this.SMS.HeaderText = "Сообщение";
            this.SMS.Name = "SMS";
            this.SMS.ReadOnly = true;
            // 
            // ContentId
            // 
            this.ContentId.DataPropertyName = "id";
            this.ContentId.HeaderText = "Id";
            this.ContentId.Name = "ContentId";
            this.ContentId.ReadOnly = true;
            this.ContentId.Visible = false;
            // 
            // ContentMessageId
            // 
            this.ContentMessageId.DataPropertyName = "MessageId";
            this.ContentMessageId.HeaderText = "MessageId";
            this.ContentMessageId.Name = "ContentMessageId";
            this.ContentMessageId.ReadOnly = true;
            this.ContentMessageId.Visible = false;
            // 
            // ContentDeliveryId
            // 
            this.ContentDeliveryId.DataPropertyName = "DeliveryId";
            this.ContentDeliveryId.HeaderText = "ContentDeliveryId";
            this.ContentDeliveryId.Name = "ContentDeliveryId";
            this.ContentDeliveryId.ReadOnly = true;
            this.ContentDeliveryId.Visible = false;
            // 
            // ContentContactId
            // 
            this.ContentContactId.DataPropertyName = "ContactId";
            this.ContentContactId.HeaderText = "ContentContactId";
            this.ContentContactId.Name = "ContentContactId";
            this.ContentContactId.ReadOnly = true;
            this.ContentContactId.Visible = false;
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshButton});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(770, 25);
            this.toolStrip4.TabIndex = 2;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(127, 22);
            this.refreshButton.Text = "Обновить статусы";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // optionsPage
            // 
            this.optionsPage.Controls.Add(this.groupBox2);
            this.optionsPage.Controls.Add(this.groupBox3);
            this.optionsPage.Controls.Add(this.proxyGroupBox);
            this.optionsPage.Controls.Add(this.groupBox1);
            this.optionsPage.ImageIndex = 3;
            this.optionsPage.Location = new System.Drawing.Point(4, 23);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Size = new System.Drawing.Size(776, 442);
            this.optionsPage.TabIndex = 3;
            this.optionsPage.Text = "Настройки";
            this.optionsPage.UseVisualStyleBackColor = true;
            this.optionsPage.Leave += new System.EventHandler(this.OptionsPageLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backupButton);
            this.groupBox2.Controls.Add(this.exploreButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резервное копирование";
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(9, 19);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(201, 23);
            this.backupButton.TabIndex = 1;
            this.backupButton.Text = "Создать копию базы данных";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.BackupButtonClick);
            // 
            // exploreButton
            // 
            this.exploreButton.Location = new System.Drawing.Point(9, 48);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.Size = new System.Drawing.Size(201, 23);
            this.exploreButton.TabIndex = 0;
            this.exploreButton.Text = "Открыть папку в Проводнике";
            this.exploreButton.UseVisualStyleBackColor = true;
            this.exploreButton.Click += new System.EventHandler(this.ExploreButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.senderTextBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 49);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отправитель";
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(6, 19);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(204, 20);
            this.senderTextBox.TabIndex = 5;
            // 
            // proxyGroupBox
            // 
            this.proxyGroupBox.Controls.Add(this.proxyPortNumericUpDown);
            this.proxyGroupBox.Controls.Add(this.useAuthCheckBox);
            this.proxyGroupBox.Controls.Add(this.proxyAddressTextBox);
            this.proxyGroupBox.Controls.Add(this.proxyPasswordTextBox);
            this.proxyGroupBox.Controls.Add(this.proxyLoginTextBox);
            this.proxyGroupBox.Controls.Add(this.label8);
            this.proxyGroupBox.Controls.Add(this.proxyPasswordLabel);
            this.proxyGroupBox.Controls.Add(this.proxyLoginLabel);
            this.proxyGroupBox.Controls.Add(this.label5);
            this.proxyGroupBox.Location = new System.Drawing.Point(233, 3);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(241, 158);
            this.proxyGroupBox.TabIndex = 6;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Прокси-сервер";
            this.proxyGroupBox.Leave += new System.EventHandler(this.ProxyGroupBoxLeave);
            // 
            // proxyPortNumericUpDown
            // 
            this.proxyPortNumericUpDown.Location = new System.Drawing.Point(175, 38);
            this.proxyPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.proxyPortNumericUpDown.Name = "proxyPortNumericUpDown";
            this.proxyPortNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.proxyPortNumericUpDown.TabIndex = 8;
            this.proxyPortNumericUpDown.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // useAuthCheckBox
            // 
            this.useAuthCheckBox.AutoSize = true;
            this.useAuthCheckBox.Location = new System.Drawing.Point(12, 74);
            this.useAuthCheckBox.Name = "useAuthCheckBox";
            this.useAuthCheckBox.Size = new System.Drawing.Size(147, 17);
            this.useAuthCheckBox.TabIndex = 9;
            this.useAuthCheckBox.Text = "Требуется авторизация";
            this.useAuthCheckBox.UseVisualStyleBackColor = true;
            this.useAuthCheckBox.CheckedChanged += new System.EventHandler(this.UseAuthCheckBoxCheckedChanged);
            // 
            // proxyAddressTextBox
            // 
            this.proxyAddressTextBox.Location = new System.Drawing.Point(9, 38);
            this.proxyAddressTextBox.Name = "proxyAddressTextBox";
            this.proxyAddressTextBox.Size = new System.Drawing.Size(150, 20);
            this.proxyAddressTextBox.TabIndex = 7;
            // 
            // proxyPasswordTextBox
            // 
            this.proxyPasswordTextBox.Enabled = false;
            this.proxyPasswordTextBox.Location = new System.Drawing.Point(80, 127);
            this.proxyPasswordTextBox.Name = "proxyPasswordTextBox";
            this.proxyPasswordTextBox.PasswordChar = '*';
            this.proxyPasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.proxyPasswordTextBox.TabIndex = 11;
            // 
            // proxyLoginTextBox
            // 
            this.proxyLoginTextBox.Enabled = false;
            this.proxyLoginTextBox.Location = new System.Drawing.Point(80, 97);
            this.proxyLoginTextBox.Name = "proxyLoginTextBox";
            this.proxyLoginTextBox.Size = new System.Drawing.Size(150, 20);
            this.proxyLoginTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = ":";
            // 
            // proxyPasswordLabel
            // 
            this.proxyPasswordLabel.AutoSize = true;
            this.proxyPasswordLabel.Enabled = false;
            this.proxyPasswordLabel.Location = new System.Drawing.Point(26, 130);
            this.proxyPasswordLabel.Name = "proxyPasswordLabel";
            this.proxyPasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.proxyPasswordLabel.TabIndex = 3;
            this.proxyPasswordLabel.Text = "Пароль:";
            // 
            // proxyLoginLabel
            // 
            this.proxyLoginLabel.AutoSize = true;
            this.proxyLoginLabel.Enabled = false;
            this.proxyLoginLabel.Location = new System.Drawing.Point(33, 100);
            this.proxyLoginLabel.Name = "proxyLoginLabel";
            this.proxyLoginLabel.Size = new System.Drawing.Size(41, 13);
            this.proxyLoginLabel.TabIndex = 2;
            this.proxyLoginLabel.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HTTP прокси сервер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // authButton
            // 
            this.authButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.authButton.Location = new System.Drawing.Point(138, 74);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(75, 23);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Сохранить";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.AuthButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(60, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Location = new System.Drawing.Point(60, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "address_book.png");
            this.imageList.Images.SetKeyName(1, "mail--plus.png");
            this.imageList.Images.SetKeyName(2, "mails.png");
            this.imageList.Images.SetKeyName(3, "gear.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpButton,
            this.statusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(784, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // helpButton
            // 
            this.helpButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(5);
            this.helpButton.Size = new System.Drawing.Size(112, 30);
            this.helpButton.Text = "О программе";
            this.helpButton.Click += new System.EventHandler(this.HelpButtonClick);
            // 
            // statusLabel
            // 
            this.statusLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.statusLabel.Size = new System.Drawing.Size(120, 30);
            this.statusLabel.Text = "Загрузка данных";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы дампа (*.ebd)|*.ebd|Все файлы (*.*)|*.*";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSourceChanged += new System.EventHandler(this.DeliveryBindingSourceDataSourceChanged);
            // 
            // settingsBackgroundWorker
            // 
            this.settingsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SettingsBackgroundWorkerDoWork);
            // 
            // csvSaveFileDialog
            // 
            this.csvSaveFileDialog.DefaultExt = "csv";
            this.csvSaveFileDialog.FileName = "Адресная книга";
            this.csvSaveFileDialog.Filter = "CSV (*.csv)|*.csv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "MainForm";
            this.Text = "B2B - СМС рассылка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.tabControl.ResumeLayout(false);
            this.addressBookPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.contactsToolStrip.ResumeLayout(false);
            this.contactsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            this.groupToolStrip.ResumeLayout(false);
            this.groupToolStrip.PerformLayout();
            this.createDeliveryPage.ResumeLayout(false);
            this.createDeliveryPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGridView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.deliveryPage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendedSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentDeliveryGridView)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.optionsPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.proxyGroupBox.ResumeLayout(false);
            this.proxyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addressBookPage;
        private System.Windows.Forms.TabPage deliveryPage;
        private System.Windows.Forms.DataGridView groupGridView;
        private System.Windows.Forms.ToolStrip groupToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton addGroupButton;
        private System.Windows.Forms.ToolStripButton removeGroupButton;
        private System.Windows.Forms.ToolStripButton editGroupButton;
        private System.Windows.Forms.DataGridView contactsGridView;
        private System.Windows.Forms.ToolStrip contactsToolStrip;
        private System.Windows.Forms.ToolStripButton addContactButton;
        private System.Windows.Forms.ToolStripButton editContactButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.ToolStripLabel statusLabel;
        private System.Windows.Forms.ToolStripButton removeContactButton;
        private System.Windows.Forms.TabPage createDeliveryPage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage optionsPage;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox deliveryNameTextBox;
        private System.Windows.Forms.ToolStripDropDownButton lablesButton;
        private System.Windows.Forms.ToolStripMenuItem firstnameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastnameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronymicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honorificMenuItem;
        private System.Windows.Forms.ToolStripLabel countSymbolsLabel;
        private System.Windows.Forms.ToolStripButton addToDeliveryButton;
        private System.Windows.Forms.DataGridView deliveryGridView;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCount;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton importDumpButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.GroupBox proxyGroupBox;
        private System.Windows.Forms.NumericUpDown proxyPortNumericUpDown;
        private System.Windows.Forms.CheckBox useAuthCheckBox;
        private System.Windows.Forms.TextBox proxyAddressTextBox;
        private System.Windows.Forms.TextBox proxyPasswordTextBox;
        private System.Windows.Forms.TextBox proxyLoginTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label proxyPasswordLabel;
        private System.Windows.Forms.Label proxyLoginLabel;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.ToolStripButton addNumbersButton;
        private System.Windows.Forms.ToolStripButton removeNumberButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.ToolStripLabel deliveryStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView sendedGridView;
        private System.ComponentModel.BackgroundWorker settingsBackgroundWorker;
        private System.Windows.Forms.CheckBox translitCheckBox;
        private System.Windows.Forms.BindingSource sendedSource;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryId1;
        private System.Windows.Forms.DataGridView contentDeliveryGridView;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentMessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentContactId;
        private System.Windows.Forms.ToolStripButton filterButton;
        private System.Windows.Forms.DataGridViewImageColumn SexImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryBirthdayDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryBirtdayMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryBirtdayYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryMessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverySex;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryBirthDayYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryBirthDayMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryMessage;
        private System.Windows.Forms.ToolStripButton importCSVButton;
        private System.Windows.Forms.ToolStripButton exportCSVButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button exploreButton;
        private System.Windows.Forms.SaveFileDialog csvSaveFileDialog;
    }
}

