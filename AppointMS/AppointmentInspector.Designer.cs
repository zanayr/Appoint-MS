namespace c969_Fickenscher
{
    partial class AppointmentInspector
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.URLField = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.TitleField = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UpdatedByField = new System.Windows.Forms.TextBox();
            this.UpdatedByLabel = new System.Windows.Forms.Label();
            this.DateUpdatedField = new System.Windows.Forms.TextBox();
            this.DateUpdatedLabel = new System.Windows.Forms.Label();
            this.CreatedByField = new System.Windows.Forms.TextBox();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.DateCreatedField = new System.Windows.Forms.TextBox();
            this.DateCreatedLabel = new System.Windows.Forms.Label();
            this.AppointmentIDField = new System.Windows.Forms.TextBox();
            this.AppointmentIDLabel = new System.Windows.Forms.Label();
            this.CutomerLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CustomerInspectorCancelButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.ContactField = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.CustomerDropList = new System.Windows.Forms.ComboBox();
            this.UserDropList = new System.Windows.Forms.ComboBox();
            this.TypeDropList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocationDropList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(11, 103);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(25, 12);
            this.TypeLabel.TabIndex = 251;
            this.TypeLabel.Text = "Type";
            // 
            // URLField
            // 
            this.URLField.Location = new System.Drawing.Point(98, 198);
            this.URLField.Name = "URLField";
            this.URLField.Size = new System.Drawing.Size(174, 18);
            this.URLField.TabIndex = 6;
            this.URLField.TextChanged += new System.EventHandler(this.EditableFields_TextChange);
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(12, 201);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(24, 12);
            this.URLLabel.TabIndex = 248;
            this.URLLabel.Text = "URL";
            // 
            // DescriptionField
            // 
            this.DescriptionField.Location = new System.Drawing.Point(98, 150);
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(174, 42);
            this.DescriptionField.TabIndex = 5;
            this.DescriptionField.TextChanged += new System.EventHandler(this.EditableFields_TextChange);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(11, 153);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(52, 12);
            this.DescriptionLabel.TabIndex = 249;
            this.DescriptionLabel.Text = "Description";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.ForeColor = System.Drawing.Color.Blue;
            this.ResponseLabel.Location = new System.Drawing.Point(96, 9);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(61, 12);
            this.ResponseLabel.TabIndex = 255;
            this.ResponseLabel.Text = "Lorem ipsum.";
            // 
            // TitleField
            // 
            this.TitleField.Location = new System.Drawing.Point(98, 126);
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(174, 18);
            this.TitleField.TabIndex = 4;
            this.TitleField.TextChanged += new System.EventHandler(this.EditableFields_TextChange);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(11, 129);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(22, 12);
            this.TitleLabel.TabIndex = 250;
            this.TitleLabel.Text = "Title";
            // 
            // UpdatedByField
            // 
            this.UpdatedByField.Enabled = false;
            this.UpdatedByField.Location = new System.Drawing.Point(98, 419);
            this.UpdatedByField.Name = "UpdatedByField";
            this.UpdatedByField.Size = new System.Drawing.Size(174, 18);
            this.UpdatedByField.TabIndex = 17;
            // 
            // UpdatedByLabel
            // 
            this.UpdatedByLabel.AutoSize = true;
            this.UpdatedByLabel.Location = new System.Drawing.Point(11, 422);
            this.UpdatedByLabel.Name = "UpdatedByLabel";
            this.UpdatedByLabel.Size = new System.Drawing.Size(53, 12);
            this.UpdatedByLabel.TabIndex = 240;
            this.UpdatedByLabel.Text = "Updated By";
            // 
            // DateUpdatedField
            // 
            this.DateUpdatedField.Enabled = false;
            this.DateUpdatedField.Location = new System.Drawing.Point(98, 395);
            this.DateUpdatedField.Name = "DateUpdatedField";
            this.DateUpdatedField.Size = new System.Drawing.Size(174, 18);
            this.DateUpdatedField.TabIndex = 16;
            // 
            // DateUpdatedLabel
            // 
            this.DateUpdatedLabel.AutoSize = true;
            this.DateUpdatedLabel.Location = new System.Drawing.Point(11, 398);
            this.DateUpdatedLabel.Name = "DateUpdatedLabel";
            this.DateUpdatedLabel.Size = new System.Drawing.Size(62, 12);
            this.DateUpdatedLabel.TabIndex = 241;
            this.DateUpdatedLabel.Text = "Date Updated";
            // 
            // CreatedByField
            // 
            this.CreatedByField.Enabled = false;
            this.CreatedByField.Location = new System.Drawing.Point(98, 371);
            this.CreatedByField.Name = "CreatedByField";
            this.CreatedByField.Size = new System.Drawing.Size(174, 18);
            this.CreatedByField.TabIndex = 15;
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Location = new System.Drawing.Point(11, 374);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(51, 12);
            this.CreatedByLabel.TabIndex = 242;
            this.CreatedByLabel.Text = "Created By";
            // 
            // DateCreatedField
            // 
            this.DateCreatedField.Enabled = false;
            this.DateCreatedField.Location = new System.Drawing.Point(98, 347);
            this.DateCreatedField.Name = "DateCreatedField";
            this.DateCreatedField.Size = new System.Drawing.Size(174, 18);
            this.DateCreatedField.TabIndex = 14;
            // 
            // DateCreatedLabel
            // 
            this.DateCreatedLabel.AutoSize = true;
            this.DateCreatedLabel.Location = new System.Drawing.Point(11, 350);
            this.DateCreatedLabel.Name = "DateCreatedLabel";
            this.DateCreatedLabel.Size = new System.Drawing.Size(60, 12);
            this.DateCreatedLabel.TabIndex = 243;
            this.DateCreatedLabel.Text = "Date Created";
            // 
            // AppointmentIDField
            // 
            this.AppointmentIDField.Enabled = false;
            this.AppointmentIDField.Location = new System.Drawing.Point(98, 24);
            this.AppointmentIDField.Name = "AppointmentIDField";
            this.AppointmentIDField.Size = new System.Drawing.Size(174, 18);
            this.AppointmentIDField.TabIndex = 0;
            this.AppointmentIDField.Text = "Generated ID";
            // 
            // AppointmentIDLabel
            // 
            this.AppointmentIDLabel.AutoSize = true;
            this.AppointmentIDLabel.Location = new System.Drawing.Point(12, 27);
            this.AppointmentIDLabel.Name = "AppointmentIDLabel";
            this.AppointmentIDLabel.Size = new System.Drawing.Size(70, 12);
            this.AppointmentIDLabel.TabIndex = 254;
            this.AppointmentIDLabel.Text = "Appointment ID";
            // 
            // CutomerLabel
            // 
            this.CutomerLabel.AutoSize = true;
            this.CutomerLabel.Location = new System.Drawing.Point(12, 51);
            this.CutomerLabel.Name = "CutomerLabel";
            this.CutomerLabel.Size = new System.Drawing.Size(46, 12);
            this.CutomerLabel.TabIndex = 253;
            this.CutomerLabel.Text = "Customer";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(222, 472);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(50, 23);
            this.OkButton.TabIndex = 17;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CustomerInspectorCancelButton
            // 
            this.CustomerInspectorCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CustomerInspectorCancelButton.Location = new System.Drawing.Point(12, 472);
            this.CustomerInspectorCancelButton.Name = "CustomerInspectorCancelButton";
            this.CustomerInspectorCancelButton.Size = new System.Drawing.Size(50, 23);
            this.CustomerInspectorCancelButton.TabIndex = 18;
            this.CustomerInspectorCancelButton.Text = "Cancel";
            this.CustomerInspectorCancelButton.UseVisualStyleBackColor = true;
            this.CustomerInspectorCancelButton.Click += new System.EventHandler(this.CustomerInspectorCancelButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(11, 77);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(25, 12);
            this.UserLabel.TabIndex = 252;
            this.UserLabel.Text = "User";
            // 
            // ContactField
            // 
            this.ContactField.Enabled = false;
            this.ContactField.Location = new System.Drawing.Point(98, 222);
            this.ContactField.Name = "ContactField";
            this.ContactField.Size = new System.Drawing.Size(174, 18);
            this.ContactField.TabIndex = 7;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(12, 225);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(38, 12);
            this.ContactLabel.TabIndex = 247;
            this.ContactLabel.Text = "Contact";
            // 
            // CustomerDropList
            // 
            this.CustomerDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerDropList.FormattingEnabled = true;
            this.CustomerDropList.Location = new System.Drawing.Point(98, 48);
            this.CustomerDropList.Name = "CustomerDropList";
            this.CustomerDropList.Size = new System.Drawing.Size(174, 20);
            this.CustomerDropList.TabIndex = 1;
            // 
            // UserDropList
            // 
            this.UserDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserDropList.FormattingEnabled = true;
            this.UserDropList.Location = new System.Drawing.Point(98, 74);
            this.UserDropList.Name = "UserDropList";
            this.UserDropList.Size = new System.Drawing.Size(174, 20);
            this.UserDropList.TabIndex = 2;
            // 
            // TypeDropList
            // 
            this.TypeDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDropList.FormattingEnabled = true;
            this.TypeDropList.Location = new System.Drawing.Point(98, 100);
            this.TypeDropList.Name = "TypeDropList";
            this.TypeDropList.Size = new System.Drawing.Size(174, 20);
            this.TypeDropList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 244;
            this.label1.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 245;
            this.label2.Text = "Start Time";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.AllowDrop = true;
            this.StartDatePicker.CustomFormat = "";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(98, 272);
            this.StartDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(2018, 11, 2, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(91, 18);
            this.StartDatePicker.TabIndex = 9;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm:ss tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(195, 272);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(77, 18);
            this.StartTimePicker.TabIndex = 10;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "hh:mm:ss tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(195, 296);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(77, 18);
            this.EndTimePicker.TabIndex = 12;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.AllowDrop = true;
            this.EndDatePicker.CustomFormat = "";
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(98, 296);
            this.EndDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(2018, 11, 2, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(91, 18);
            this.EndDatePicker.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 246;
            this.label3.Text = "Location";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(c969_Fickenscher.Customer);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(c969_Fickenscher.User);
            // 
            // LocationDropList
            // 
            this.LocationDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationDropList.FormattingEnabled = true;
            this.LocationDropList.Location = new System.Drawing.Point(98, 246);
            this.LocationDropList.Name = "LocationDropList";
            this.LocationDropList.Size = new System.Drawing.Size(174, 20);
            this.LocationDropList.TabIndex = 256;
            // 
            // AppointmentInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 507);
            this.Controls.Add(this.LocationDropList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeDropList);
            this.Controls.Add(this.UserDropList);
            this.Controls.Add(this.CustomerDropList);
            this.Controls.Add(this.ContactField);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.URLField);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.TitleField);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UpdatedByField);
            this.Controls.Add(this.UpdatedByLabel);
            this.Controls.Add(this.DateUpdatedField);
            this.Controls.Add(this.DateUpdatedLabel);
            this.Controls.Add(this.CreatedByField);
            this.Controls.Add(this.CreatedByLabel);
            this.Controls.Add(this.DateCreatedField);
            this.Controls.Add(this.DateCreatedLabel);
            this.Controls.Add(this.AppointmentIDField);
            this.Controls.Add(this.AppointmentIDLabel);
            this.Controls.Add(this.CutomerLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CustomerInspectorCancelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppointmentInspector";
            this.Text = "Appointment Inspector";
            this.Load += new System.EventHandler(this.AppointmentInspector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox URLField;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox DescriptionField;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.TextBox TitleField;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox UpdatedByField;
        private System.Windows.Forms.Label UpdatedByLabel;
        private System.Windows.Forms.TextBox DateUpdatedField;
        private System.Windows.Forms.Label DateUpdatedLabel;
        private System.Windows.Forms.TextBox CreatedByField;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.TextBox DateCreatedField;
        private System.Windows.Forms.Label DateCreatedLabel;
        private System.Windows.Forms.TextBox AppointmentIDField;
        private System.Windows.Forms.Label AppointmentIDLabel;
        private System.Windows.Forms.Label CutomerLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CustomerInspectorCancelButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox ContactField;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.ComboBox CustomerDropList;
        private System.Windows.Forms.ComboBox UserDropList;
        private System.Windows.Forms.ComboBox TypeDropList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox LocationDropList;
    }
}