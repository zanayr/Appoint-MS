namespace c969_Fickenscher
{
    partial class CalendarInspector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CalendarTabControl = new System.Windows.Forms.TabControl();
            this.MonthlyTab = new System.Windows.Forms.TabPage();
            this.MonthDataGridView = new System.Windows.Forms.DataGridView();
            this.WeeklyTab = new System.Windows.Forms.TabPage();
            this.WeekDataGridView = new System.Windows.Forms.DataGridView();
            this.DailyTab = new System.Windows.Forms.TabPage();
            this.DayDataGridView = new System.Windows.Forms.DataGridView();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CalendarLabel = new System.Windows.Forms.Label();
            this.sundayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sundayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalendarTabControl.SuspendLayout();
            this.MonthlyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDataGridView)).BeginInit();
            this.WeeklyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekDataGridView)).BeginInit();
            this.DailyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarTabControl
            // 
            this.CalendarTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.CalendarTabControl.Controls.Add(this.MonthlyTab);
            this.CalendarTabControl.Controls.Add(this.WeeklyTab);
            this.CalendarTabControl.Controls.Add(this.DailyTab);
            this.CalendarTabControl.Location = new System.Drawing.Point(12, 24);
            this.CalendarTabControl.Multiline = true;
            this.CalendarTabControl.Name = "CalendarTabControl";
            this.CalendarTabControl.SelectedIndex = 0;
            this.CalendarTabControl.Size = new System.Drawing.Size(560, 376);
            this.CalendarTabControl.TabIndex = 0;
            this.CalendarTabControl.SelectedIndexChanged += new System.EventHandler(this.CalendarTabControl_SelectedIndexChanged);
            // 
            // MonthlyTab
            // 
            this.MonthlyTab.Controls.Add(this.MonthDataGridView);
            this.MonthlyTab.Location = new System.Drawing.Point(20, 4);
            this.MonthlyTab.Name = "MonthlyTab";
            this.MonthlyTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonthlyTab.Size = new System.Drawing.Size(536, 368);
            this.MonthlyTab.TabIndex = 0;
            this.MonthlyTab.Text = "Monthly";
            this.MonthlyTab.UseVisualStyleBackColor = true;
            // 
            // MonthDataGridView
            // 
            this.MonthDataGridView.AllowUserToAddRows = false;
            this.MonthDataGridView.AllowUserToDeleteRows = false;
            this.MonthDataGridView.AutoGenerateColumns = false;
            this.MonthDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MonthDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MonthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sundayDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdayDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn,
            this.saturdayDataGridViewTextBoxColumn});
            this.MonthDataGridView.DataSource = this.weekBindingSource;
            this.MonthDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MonthDataGridView.Name = "MonthDataGridView";
            this.MonthDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MonthDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MonthDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MonthDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MonthDataGridView.Size = new System.Drawing.Size(536, 368);
            this.MonthDataGridView.TabIndex = 0;
            this.MonthDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonthDataGridView_CellClick);
            this.MonthDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // WeeklyTab
            // 
            this.WeeklyTab.BackColor = System.Drawing.SystemColors.Control;
            this.WeeklyTab.Controls.Add(this.WeekDataGridView);
            this.WeeklyTab.Location = new System.Drawing.Point(20, 4);
            this.WeeklyTab.Name = "WeeklyTab";
            this.WeeklyTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklyTab.Size = new System.Drawing.Size(536, 368);
            this.WeeklyTab.TabIndex = 1;
            this.WeeklyTab.Text = "Weekly";
            // 
            // WeekDataGridView
            // 
            this.WeekDataGridView.AllowUserToAddRows = false;
            this.WeekDataGridView.AllowUserToDeleteRows = false;
            this.WeekDataGridView.AllowUserToResizeRows = false;
            this.WeekDataGridView.AutoGenerateColumns = false;
            this.WeekDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WeekDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.WeekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sundayDataGridViewTextBoxColumn1,
            this.mondayDataGridViewTextBoxColumn1,
            this.tuesdayDataGridViewTextBoxColumn1,
            this.wednesdayDataGridViewTextBoxColumn1,
            this.thursdayDataGridViewTextBoxColumn1,
            this.fridayDataGridViewTextBoxColumn1,
            this.saturdayDataGridViewTextBoxColumn1});
            this.WeekDataGridView.DataSource = this.weekBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WeekDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.WeekDataGridView.Location = new System.Drawing.Point(0, 0);
            this.WeekDataGridView.Name = "WeekDataGridView";
            this.WeekDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WeekDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.WeekDataGridView.RowHeadersVisible = false;
            this.WeekDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.WeekDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.WeekDataGridView.RowTemplate.Height = 58;
            this.WeekDataGridView.RowTemplate.ReadOnly = true;
            this.WeekDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WeekDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WeekDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WeekDataGridView.Size = new System.Drawing.Size(536, 78);
            this.WeekDataGridView.TabIndex = 1;
            this.WeekDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WeekDataGridView_CellClick);
            this.WeekDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // DailyTab
            // 
            this.DailyTab.Controls.Add(this.DayDataGridView);
            this.DailyTab.Location = new System.Drawing.Point(20, 4);
            this.DailyTab.Name = "DailyTab";
            this.DailyTab.Padding = new System.Windows.Forms.Padding(3);
            this.DailyTab.Size = new System.Drawing.Size(536, 368);
            this.DailyTab.TabIndex = 2;
            this.DailyTab.Text = "Daily";
            this.DailyTab.UseVisualStyleBackColor = true;
            // 
            // DayDataGridView
            // 
            this.DayDataGridView.AllowUserToAddRows = false;
            this.DayDataGridView.AllowUserToDeleteRows = false;
            this.DayDataGridView.AutoGenerateColumns = false;
            this.DayDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DayDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.DayDataGridView.DataSource = this.appointmentBindingSource;
            this.DayDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DayDataGridView.Name = "DayDataGridView";
            this.DayDataGridView.ReadOnly = true;
            this.DayDataGridView.RowHeadersVisible = false;
            this.DayDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DayDataGridView.Size = new System.Drawing.Size(536, 368);
            this.DayDataGridView.TabIndex = 1;
            this.DayDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DayDataGridView_CellDoubleClick);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(12, 406);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(50, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(522, 406);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CalendarLabel
            // 
            this.CalendarLabel.AutoSize = true;
            this.CalendarLabel.ForeColor = System.Drawing.Color.Blue;
            this.CalendarLabel.Location = new System.Drawing.Point(10, 9);
            this.CalendarLabel.Name = "CalendarLabel";
            this.CalendarLabel.Size = new System.Drawing.Size(58, 12);
            this.CalendarLabel.TabIndex = 3;
            this.CalendarLabel.Text = "Current Date";
            // 
            // sundayDataGridViewTextBoxColumn
            // 
            this.sundayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sundayDataGridViewTextBoxColumn.DataPropertyName = "Sunday";
            this.sundayDataGridViewTextBoxColumn.HeaderText = "Sunday";
            this.sundayDataGridViewTextBoxColumn.Name = "sundayDataGridViewTextBoxColumn";
            this.sundayDataGridViewTextBoxColumn.ReadOnly = true;
            this.sundayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "Monday";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "Monday";
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            this.mondayDataGridViewTextBoxColumn.ReadOnly = true;
            this.mondayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            this.tuesdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.tuesdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            this.wednesdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.wednesdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // thursdayDataGridViewTextBoxColumn
            // 
            this.thursdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thursdayDataGridViewTextBoxColumn.DataPropertyName = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.HeaderText = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.Name = "thursdayDataGridViewTextBoxColumn";
            this.thursdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.thursdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "Friday";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "Friday";
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            this.fridayDataGridViewTextBoxColumn.ReadOnly = true;
            this.fridayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // saturdayDataGridViewTextBoxColumn
            // 
            this.saturdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saturdayDataGridViewTextBoxColumn.DataPropertyName = "Saturday";
            this.saturdayDataGridViewTextBoxColumn.HeaderText = "Saturday";
            this.saturdayDataGridViewTextBoxColumn.Name = "saturdayDataGridViewTextBoxColumn";
            this.saturdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.saturdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataSource = typeof(c969_Fickenscher.Week);
            // 
            // sundayDataGridViewTextBoxColumn1
            // 
            this.sundayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sundayDataGridViewTextBoxColumn1.DataPropertyName = "Sunday";
            this.sundayDataGridViewTextBoxColumn1.HeaderText = "Sunday";
            this.sundayDataGridViewTextBoxColumn1.Name = "sundayDataGridViewTextBoxColumn1";
            this.sundayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sundayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mondayDataGridViewTextBoxColumn1
            // 
            this.mondayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mondayDataGridViewTextBoxColumn1.DataPropertyName = "Monday";
            this.mondayDataGridViewTextBoxColumn1.HeaderText = "Monday";
            this.mondayDataGridViewTextBoxColumn1.Name = "mondayDataGridViewTextBoxColumn1";
            this.mondayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mondayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tuesdayDataGridViewTextBoxColumn1
            // 
            this.tuesdayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tuesdayDataGridViewTextBoxColumn1.DataPropertyName = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn1.HeaderText = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn1.Name = "tuesdayDataGridViewTextBoxColumn1";
            this.tuesdayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tuesdayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // wednesdayDataGridViewTextBoxColumn1
            // 
            this.wednesdayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wednesdayDataGridViewTextBoxColumn1.DataPropertyName = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn1.HeaderText = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn1.Name = "wednesdayDataGridViewTextBoxColumn1";
            this.wednesdayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wednesdayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // thursdayDataGridViewTextBoxColumn1
            // 
            this.thursdayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thursdayDataGridViewTextBoxColumn1.DataPropertyName = "Thursday";
            this.thursdayDataGridViewTextBoxColumn1.HeaderText = "Thursday";
            this.thursdayDataGridViewTextBoxColumn1.Name = "thursdayDataGridViewTextBoxColumn1";
            this.thursdayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.thursdayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fridayDataGridViewTextBoxColumn1
            // 
            this.fridayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fridayDataGridViewTextBoxColumn1.DataPropertyName = "Friday";
            this.fridayDataGridViewTextBoxColumn1.HeaderText = "Friday";
            this.fridayDataGridViewTextBoxColumn1.Name = "fridayDataGridViewTextBoxColumn1";
            this.fridayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fridayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // saturdayDataGridViewTextBoxColumn1
            // 
            this.saturdayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saturdayDataGridViewTextBoxColumn1.DataPropertyName = "Saturday";
            this.saturdayDataGridViewTextBoxColumn1.HeaderText = "Saturday";
            this.saturdayDataGridViewTextBoxColumn1.Name = "saturdayDataGridViewTextBoxColumn1";
            this.saturdayDataGridViewTextBoxColumn1.ReadOnly = true;
            this.saturdayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // CalendarInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.CalendarLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.CalendarTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalendarInspector";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.CalendarTabControl.ResumeLayout(false);
            this.MonthlyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthDataGridView)).EndInit();
            this.WeeklyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeekDataGridView)).EndInit();
            this.DailyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl CalendarTabControl;
        private System.Windows.Forms.TabPage MonthlyTab;
        private System.Windows.Forms.TabPage WeeklyTab;
        private System.Windows.Forms.TabPage DailyTab;
        private System.Windows.Forms.DataGridView WeekDataGridView;
        private System.Windows.Forms.DataGridView DayDataGridView;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label CalendarLabel;
        private System.Windows.Forms.DataGridView MonthDataGridView;
        private System.Windows.Forms.BindingSource weekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
    }
}