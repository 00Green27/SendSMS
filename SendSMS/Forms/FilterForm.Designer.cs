namespace SendSMS.Forms
{
    partial class FilterForm
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
            this.filterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.allSexRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fisrtNameLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(136, 96);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(88, 23);
            this.filterButton.TabIndex = 18;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.maleRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.allSexRadioButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.femaleRadioButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 41);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maleRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(79, 35);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.Text = "Мужской";
            this.maleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allSexRadioButton
            // 
            this.allSexRadioButton.AutoSize = true;
            this.allSexRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allSexRadioButton.Checked = true;
            this.allSexRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSexRadioButton.Location = new System.Drawing.Point(173, 3);
            this.allSexRadioButton.Name = "allSexRadioButton";
            this.allSexRadioButton.Size = new System.Drawing.Size(81, 35);
            this.allSexRadioButton.TabIndex = 9;
            this.allSexRadioButton.TabStop = true;
            this.allSexRadioButton.Text = "Все";
            this.allSexRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.femaleRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.femaleRadioButton.Location = new System.Drawing.Point(88, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(79, 35);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.Text = "Женский";
            this.femaleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(230, 96);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(48, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // fisrtNameLabel
            // 
            this.fisrtNameLabel.AutoSize = true;
            this.fisrtNameLabel.Location = new System.Drawing.Point(10, 15);
            this.fisrtNameLabel.Name = "fisrtNameLabel";
            this.fisrtNameLabel.Size = new System.Drawing.Size(32, 13);
            this.fisrtNameLabel.TabIndex = 16;
            this.fisrtNameLabel.Text = "Имя:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(12, 42);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 13);
            this.sexLabel.TabIndex = 14;
            this.sexLabel.Text = "Пол:";
            // 
            // FilterForm
            // 
            this.AcceptButton = this.filterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 129);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.fisrtNameLabel);
            this.Controls.Add(this.sexLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фильтр";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton allSexRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label fisrtNameLabel;
        private System.Windows.Forms.Label sexLabel;
    }
}