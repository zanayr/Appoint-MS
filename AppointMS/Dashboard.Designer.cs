namespace c969_Fickenscher
{
    partial class Dashboard
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
            this.DashboardTabControl = new System.Windows.Forms.TabControl();
            this.AppointmentsTab = new System.Windows.Forms.TabPage();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CutomerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.InspectButton = new System.Windows.Forms.Button();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.ReportComboBox = new System.Windows.Forms.ComboBox();
            this.App15Reminder = new System.Windows.Forms.Timer(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DashboardTabControl.SuspendLayout();
            this.AppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardTabControl
            // 
            this.DashboardTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.DashboardTabControl.Controls.Add(this.AppointmentsTab);
            this.DashboardTabControl.Controls.Add(this.CustomersTab);
            this.DashboardTabControl.Location = new System.Drawing.Point(12, 41);
            this.DashboardTabControl.Multiline = true;
            this.DashboardTabControl.Name = "DashboardTabControl";
            this.DashboardTabControl.SelectedIndex = 0;
            this.DashboardTabControl.Size = new System.Drawing.Size(560, 359);
            this.DashboardTabControl.TabIndex = 6;
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.AppointmentsDataGridView);
            this.AppointmentsTab.Location = new System.Drawing.Point(20, 4);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTab.Size = new System.Drawing.Size(536, 351);
            this.AppointmentsTab.TabIndex = 0;
            this.AppointmentsTab.Text = "Appointments";
            this.AppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AutoGenerateColumns = false;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.AppointmentsDataGridView.DataSource = this.appointmentBindingSource;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.RowHeadersVisible = false;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(536, 351);
            this.AppointmentsDataGridView.TabIndex = 0;
            this.AppointmentsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 25;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeDataGridViewTextBoxColumn.Width = 75;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(c969_Fickenscher.Appointment);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.CustomersDataGridView);
            this.CustomersTab.Location = new System.Drawing.Point(20, 4);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(536, 351);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            this.CustomersDataGridView.AutoGenerateColumns = false;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.CutomerCity,
            this.CustomerCountry});
            this.CustomersDataGridView.DataSource = this.customerBindingSource;
            this.CustomersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            this.CustomersDataGridView.RowHeadersVisible = false;
            this.CustomersDataGridView.Size = new System.Drawing.Size(536, 351);
            this.CustomersDataGridView.TabIndex = 0;
            this.CustomersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn1.Width = 25;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activeDataGridViewCheckBoxColumn.Width = 50;
            // 
            // CutomerCity
            // 
            this.CutomerCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CutomerCity.DataPropertyName = "CityName";
            this.CutomerCity.HeaderText = "City";
            this.CutomerCity.MaxInputLength = 255;
            this.CutomerCity.Name = "CutomerCity";
            this.CutomerCity.ReadOnly = true;
            this.CutomerCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CustomerCountry
            // 
            this.CustomerCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerCountry.DataPropertyName = "CountryName";
            this.CustomerCountry.HeaderText = "Country";
            this.CustomerCountry.Name = "CustomerCountry";
            this.CustomerCountry.ReadOnly = true;
            this.CustomerCountry.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(c969_Fickenscher.Customer);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Location = new System.Drawing.Point(32, 406);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CalendarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarButton.Location = new System.Drawing.Point(522, 12);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(50, 23);
            this.CalendarButton.TabIndex = 3;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.UseVisualStyleBackColor = false;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // InspectButton
            // 
            this.InspectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InspectButton.Location = new System.Drawing.Point(522, 406);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(50, 23);
            this.InspectButton.TabIndex = 5;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = true;
            this.InspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.ForeColor = System.Drawing.Color.Blue;
            this.ResponseLabel.Location = new System.Drawing.Point(88, 411);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(47, 12);
            this.ResponseLabel.TabIndex = 99;
            this.ResponseLabel.Text = "Welcome!";
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddButton.Location = new System.Drawing.Point(466, 406);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 23);
            this.AddButton.TabIndex = 100;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReportButton.Location = new System.Drawing.Point(266, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(50, 23);
            this.ReportButton.TabIndex = 101;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ReportComboBox
            // 
            this.ReportComboBox.FormattingEnabled = true;
            this.ReportComboBox.Location = new System.Drawing.Point(12, 14);
            this.ReportComboBox.Name = "ReportComboBox";
            this.ReportComboBox.Size = new System.Drawing.Size(248, 20);
            this.ReportComboBox.TabIndex = 102;
            // 
            // App15Reminder
            // 
            this.App15Reminder.Interval = 30000;
            this.App15Reminder.Tick += new System.EventHandler(this.App15Reminder_Tick);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(c969_Fickenscher.Customer);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.ReportComboBox);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.InspectButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.DashboardTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.DashboardTabControl.ResumeLayout(false);
            this.AppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.CustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DashboardTabControl;
        private System.Windows.Forms.TabPage AppointmentsTab;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button InspectButton;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ComboBox ReportComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutomerCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCountry;
        private System.Windows.Forms.Timer App15Reminder;
    }
}