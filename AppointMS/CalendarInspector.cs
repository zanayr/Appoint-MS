using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace c969_Fickenscher
{
    public partial class CalendarInspector : Form
    {
        private DateTime _selectedDate;
        private DateTime _currentMonth;
        private DateTime _currentWeek;
        private Color _oneBlue = Color.FromArgb(235, 240, 255);
        private Color _twoBlue = Color.FromArgb(190, 205, 255);
        private Color _manyBlue = Color.FromArgb(135, 160, 255);

        public CalendarInspector()
        {
            InitializeComponent();
            _selectedDate = DateTime.Now.Date;
            _currentMonth = new DateTime(_selectedDate.Year, _selectedDate.Month, 1, 0, 0, 0);
            _currentWeek = _selectedDate.AddDays(6 - (6 + Convert.ToInt32(_selectedDate.DayOfWeek)));
        }

        private void ToggleCalendarInspector()
        {
            CalendarTabControl.Enabled = !CalendarTabControl.Enabled;
            PrevButton.Enabled = !PrevButton.Enabled;
            NextButton.Enabled = !NextButton.Enabled;
        }

        private int GetDaysInMonth(int month)
        {
            int total;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    total = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    total = 30;
                    break;
                case 2:
                default:
                    total = 28;
                    break;
            }
            // Check for leap year;
            if (_currentMonth.Year % 4 == 0)
            {
                total = 29;
            }
            return total;
        }

        private void ColorCells(DataGridViewCell cell, DateTime date)
        {
            if (_selectedDate == date.Date)
            {
                cell.Selected = true;
            }
            foreach (Appointment appointment in Appointments.AllAppointmentsList)
            {
                if (appointment.StartDate.Date == date.Date)
                {
                    if (cell.Style.BackColor == Color.White)
                    {
                        cell.Style.BackColor = _oneBlue;
                    }
                    else if (cell.Style.BackColor == _oneBlue)
                    {
                        cell.Style.BackColor = _twoBlue;
                    }
                    else
                    {
                        cell.Style.BackColor = _manyBlue;
                    }
                }
            }
        }

        private BindingList<Week> GetMonthCalendar(int offset)
        {
            BindingList<Week> month = new BindingList<Week>();
            int counter = 1;
            for (int i = 0; i < 6; i++)
            {
                Week week = new Week(i);
                for (int j = 0; j < 7; j++)
                {
                    Day day = new Day();
                    if (counter - offset <= 0)
                    {
                        day.Number = GetDaysInMonth(_currentMonth.AddMonths(-1).Month) + (counter - offset);
                        day.Date = new DateTime(_currentMonth.Year, _currentMonth.AddMonths(-1).Month, day.Number, 0, 0, 0);
                    }
                    else if (counter - offset <= GetDaysInMonth(_currentMonth.Month))
                    {
                        day.Number = counter - offset;
                        day.Date = new DateTime(_currentMonth.Year, _currentMonth.Month, day.Number, 0, 0, 0);
                    }
                    else
                    {
                        day.Number = (counter - offset) - GetDaysInMonth(_currentMonth.Month);
                        day.Date = new DateTime(_currentMonth.Year, _currentMonth.AddMonths(1).Month, day.Number, 0, 0, 0);
                    }
                    week.SortDay(day, j);
                    counter++;
                }
                month.Add(week);
            }
            return month;
        }

        private BindingList<Week> GetWeekCalendar()
        {
            BindingList<Week> weekList = new BindingList<Week>();
            Week week = new Week(0);
            int counter = _currentWeek.Day;
            int totalDaysInMonth = GetDaysInMonth(_currentWeek.Month);
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                day.Number = counter + i;
                day.Date = new DateTime(_currentWeek.Year, _currentWeek.Month, day.Number, 0, 0, 0);
                if (day.Number == totalDaysInMonth)
                {
                    counter = counter - totalDaysInMonth;
                    totalDaysInMonth = GetDaysInMonth(_currentWeek.AddMonths(1).Month);
                }
                week.SortDay(day, i);
            }
            weekList.Add(week);
            return weekList;
        }

        private void LoadMonthCalendar()
        {
            int offset = Convert.ToInt32(_currentMonth.DayOfWeek);
            int counter = 1;
            int totalDaysInMonth = GetDaysInMonth(_currentMonth.Month);
            MonthDataGridView.DataSource = GetMonthCalendar(offset);
            foreach (DataGridViewRow row in MonthDataGridView.Rows)
            {
                row.Height = (MonthDataGridView.ClientRectangle.Height - MonthDataGridView.ColumnHeadersHeight) / MonthDataGridView.Rows.Count;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Selected = false;
                    cell.Style.BackColor = Color.White;
                    if (counter - offset > 0 && counter - offset <= totalDaysInMonth)
                    {
                        ColorCells(cell, new DateTime(_currentMonth.Year, _currentMonth.Month, Convert.ToInt32(cell.Value), 0, 0, 0));
                    }
                    else
                    {
                        cell.Style.ForeColor = Color.Gray;
                    }
                    counter++;
                }
            }
            
        }

        private void LoadWeekCalendar()
        {
            int month = _currentWeek.Month;
            int totalDaysInMonth = GetDaysInMonth(month);
            WeekDataGridView.DataSource = GetWeekCalendar();
            foreach (DataGridViewCell cell in WeekDataGridView.Rows[0].Cells)
            {
                cell.Selected = false;
                cell.Style.BackColor = Color.White;
                DateTime cellDate = new DateTime(_currentWeek.Year, month, Convert.ToInt32(cell.Value), 0, 0, 0);
                ColorCells(cell, cellDate);
                if (cellDate.Day == totalDaysInMonth)
                {
                    if (month == 12)
                    {
                        month = 1;
                    }
                    else
                    {
                        month++;
                    }
                }
            }
        }

        private void LoadDayCalendar()
        {
            BindingList<Appointment> DayCalendarBindingList = new BindingList<Appointment>();
            foreach (Appointment appointment in Appointments.AllAppointmentsList)
            {
                if (appointment.StartDate.Date == _selectedDate)
                {
                    DayCalendarBindingList.Add(appointment);
                }
            }
            DayDataGridView.DataSource = DayCalendarBindingList;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            LoadMonthCalendar();
            LoadWeekCalendar();
            LoadDayCalendar();
            CalendarLabel.Text = _currentMonth.ToString("MMMM, yyyy");
        }

        private void CalendarTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CalendarTabControl.SelectedIndex)
            {
                case 0:
                    CalendarLabel.Text = _currentMonth.ToString("MMMM, yyyy");
                    break;
                case 1:
                    CalendarLabel.Text = "Week Starting on  " + _currentWeek.ToString("MMMM dd, yyyy");
                    break;
                case 2:
                    CalendarLabel.Text = _selectedDate.ToString("MMMM dd, yyyy");
                    break;
                default:
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch(CalendarTabControl.SelectedIndex)
            {
                case 0:
                    _currentMonth = _currentMonth.AddMonths(1);
                    LoadMonthCalendar();
                    CalendarLabel.Text = _currentMonth.ToString("MMMM, yyyy");
                    break;
                case 1:
                    _currentWeek = _currentWeek.AddDays(7);
                    LoadWeekCalendar();
                    CalendarLabel.Text = "Week Starting on  " + _currentWeek.ToString("MMMM dd, yyyy");
                    break;
                case 2:
                    _selectedDate = _selectedDate.AddDays(1);
                    LoadDayCalendar();
                    CalendarLabel.Text = _selectedDate.ToString("MMMM dd, yyyy");
                    break;
                default:
                    break;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            switch (CalendarTabControl.SelectedIndex)
            {
                case 0:
                    _currentMonth = _currentMonth.AddMonths(-1);
                    LoadMonthCalendar();
                    CalendarLabel.Text = _currentMonth.ToString("MMMM, yyyy");
                    break;
                case 1:
                    _currentWeek = _currentWeek.AddDays(-7);
                    LoadWeekCalendar();
                    CalendarLabel.Text = "Week Starting on  " + _currentWeek.ToString("MMMM dd, yyyy");
                    break;
                case 2:
                    _selectedDate = _selectedDate.AddDays(-1);
                    LoadDayCalendar();
                    CalendarLabel.Text = _selectedDate.ToString("MMMM dd, yyyy");
                    break;
                default:
                    break;
            }
        }

        private void MonthDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime selectedDate = _currentMonth;
            if (MonthDataGridView.CurrentCell.Style.ForeColor == Color.Gray)
            {
                if (Convert.ToInt32(MonthDataGridView.CurrentCell.Value) > 24)
                {
                    selectedDate = _currentMonth.AddMonths(-1);
                }
                else
                {
                    selectedDate = _currentMonth.AddMonths(1);
                }
            }
            _selectedDate = new DateTime(selectedDate.Year, selectedDate.Month, Convert.ToInt32(MonthDataGridView.CurrentCell.Value), 0, 0, 0);
            _currentWeek = _selectedDate.AddDays(6 - (6 + Convert.ToInt32(_selectedDate.DayOfWeek)));
            LoadWeekCalendar();
            LoadDayCalendar();
        }

        private void WeekDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(WeekDataGridView.CurrentCell.Value) < _currentWeek.Day)
            {
                _selectedDate = new DateTime(_currentWeek.AddMonths(1).Year, _currentWeek.AddMonths(1).Month, Convert.ToInt32(WeekDataGridView.CurrentCell.Value), 0, 0, 0);
            }
            else
            {
                _selectedDate = new DateTime(_currentWeek.Year, _currentWeek.Month, Convert.ToInt32(WeekDataGridView.CurrentCell.Value), 0, 0, 0);
            }
            LoadDayCalendar();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDayCalendar();
            CalendarTabControl.SelectedIndex = 2;
        }

        private void Inspector_Closed(object sender, EventArgs e)
        {
            LoadMonthCalendar();
            LoadWeekCalendar();
            LoadDayCalendar();
            ToggleCalendarInspector();
        }

        private void DayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isOpen = false;
            //int id;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Appointment Inspector")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                ToggleCalendarInspector();
                //id = Convert.ToInt32(DayDataGridView.CurrentRow.Cells[0].Value);
                AppointmentInspector appointmentInspector = new AppointmentInspector(Convert.ToInt32(DayDataGridView.CurrentRow.Cells[0].Value));
                appointmentInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                appointmentInspector.Show();
            }
        }
    }
}
