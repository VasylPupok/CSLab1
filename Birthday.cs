using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Birthday
    {
        public Birthday(DateTime birthday) {
            this._birthday = birthday;
        }

        public TimeSpan? Age {
            get
            {
                TimeSpan? age = DateTime.Now - _birthday;
                return (age > TimeSpan.Zero) ? age : null;
            }
        }

        public string Zodiac
        {
            get
            {
                switch (this._birthday.Month)
                {
                    case 1:
                        if (this._birthday.Day < 20)
                        {
                           return "Capricorn";
                        }
                        else
                        {
                            return "Aquarius";
                        }
                    case 2:
                        if (this._birthday.Day < 19)
                        {
                            return "Aquarius";
                        }
                        else
                        {
                            return "Pisces";
                        }
                    case 3:
                        if (this._birthday.Day < 21)
                        {
                            return "Pisces";
                        }
                        else
                        {
                            return "Aries";
                        }
                    case 4:
                        if (this._birthday.Day < 20)
                        {
                            return "Aries";
                        }
                        else
                        {
                            return "Taurus";
                        }
                    case 5:
                        if (this._birthday.Day < 21)
                        {
                            return "Taurus";
                        }
                        else
                        {
                            return "Gemini";
                        }
                    case 6:
                        if (this._birthday.Day < 22)
                        {
                            return "Gemini";
                        }
                        else
                        {
                            return "Cancer";
                        }
                    case 7:
                        if (this._birthday.Day < 23)
                        {
                            return "Cancer";
                        }
                        else
                        {
                            return "Leo";
                        }
                    case 8:
                        if (this._birthday.Day < 24)
                        {
                            return "Leo";
                        }
                        else
                        {
                            return "Virgo";
                        }
                    case 9:
                        if (this._birthday.Day < 24)
                        {
                            return "Virgo";
                        }
                        else
                        {
                            return "Libra";
                        }
                    case 10:
                        if (this._birthday.Day < 23)
                        {
                            return "Libra";
                        }
                        else
                        {
                            return "Scorpio";
                        }
                    case 11:
                        if (this._birthday.Day < 23)
                        {
                            return "Scorpio";
                        }
                        else
                        {
                            return "Sagittarius";
                        }
                    case 12:
                        if (this._birthday.Day < 22)
                        {
                            return "Sagittarius";
                        }
                        else
                        {
                            return "Capricorn";
                        }
                    default:
                        return "Error";
                }
            }
        }

        public string ChineseZodiac { 
            get
            {
                return CHINESE_SIGNS[this._birthday.Year % 12];
            } 
        }

        public bool BirthdayIsToday
        {
            get
            {
                return this._birthday.Day == DateTime.Now.Date.Day;
            }
        }

        private static string[] CHINESE_SIGNS = new string[]
        {
            "Monkey",
            "Rooster",
            "Dog",
            "Pig",
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat"
        };

        private readonly DateTime _birthday;

    }

    
}
