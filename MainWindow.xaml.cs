
using System;
using System.Windows;


namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public const double DAYS_IN_YEAR = 365.25;
        public const double MAX_ACCEPTABLE_AGE = 135;
        public const double MAX_DAYS = DAYS_IN_YEAR * MAX_ACCEPTABLE_AGE;

        public MainWindow()
        {
            InitializeComponent();
            Error("Birthday is not initialized");
        }

        public void birthdaySet(object sender, EventArgs e)
        {
            this._birthdayInfo = new Birthday(this._dateInput.SelectedDate.Value);
            if (ValidBirthday())
            {
                CheckBirthday();
                this._ageBlock.Text = $"Age: {((int)(this._birthdayInfo.Age.Value.Days / DAYS_IN_YEAR))}";
                this._zodiacBlock.Text = $"Zodiac sign: {this._birthdayInfo.Zodiac}";
                this._zodiacBlockChinese.Text = $"Chinese zodiac sign: {this._birthdayInfo.ChineseZodiac}";
            }

        }


        private Birthday _birthdayInfo = null;

        private void CheckBirthday()
        {
            if (this._birthdayInfo.BirthdayIsToday)
            {
                this._happyBirthdayText.Text = "Happy birthday, human";
            }
            else
            {
                this._happyBirthdayText.Text = "";
            }
        }

        private bool ValidBirthday()
        {
            if (_birthdayInfo == null)
            {
                Error("Birthday is not initialized");
                return false;
            }
            else if (_birthdayInfo.Age == null)
            {
                Error("Program does not work with users, who haven't been born");
                return false;
            }
            else if (_birthdayInfo.Age.Value.Days > MAX_DAYS)
            {
                Error(
                    $"Humans I work with don't live longer than {MAX_ACCEPTABLE_AGE} years.\n " +
                    $"Terminators are sent in the past to correct this mistake. Please, stand by"
                    );
                return false;
            }
            Success();
            return true;
        }

        private void Success()
        {
            this._warningTextBlock.Text = "";
        }

        private void Error(string message)
        {
            this._ageBlock.Text = "Age: ";
            this._zodiacBlockChinese.Text = "Zodiac: ";
            this._zodiacBlock.Text = "Chinese zodiac: ";

            this._warningTextBlock.Text = message;
        } 

    }
}
