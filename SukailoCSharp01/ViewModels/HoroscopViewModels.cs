using SukailoCSharp01.Models;
using SukailoCSharp01.SignsOfHoroscop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SukailoCSharp01.ViewModels
{
    internal class HoroscopViewModels : INotifyPropertyChanged
    {
        private UserInf users = new UserInf();
        private RelayCommand<object> _signCommand;
        public int Age
        {
            get { return users.Age; }
            set
            {
                users.Age = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime DateOfBirth
        {
            get
            { return users.DateOfBirth; }
            set
            {
                users.DateOfBirth = value;
                AgeCommand();
                NotifyPropertyChanged();
            }
        }
        public ZaxidnuiHoroscop WesternSign
        {
            get { return users.WesternSign; }
            set
            {
                users.WesternSign = value;
                NotifyPropertyChanged();
            }
        }
        public ChineseHoroscop ChineseSign
        {
            get { return users.ChineseSign; }
            set
            {
                users.ChineseSign = value;
                NotifyPropertyChanged();
            }
        }

        public RelayCommand<object> ShowSignsCommand
        {
            get { return _signCommand ??= new RelayCommand<object>(_ => CommandOfSign()); }
        }
        private void CommandOfSign()
        {
            WesternSign = CalculateWesternSign();
            ChineseSign = CalculateChineseSign();
        }

        private ChineseHoroscop CalculateChineseSign()
        {
            return (ChineseHoroscop)(DateOfBirth.Year % 12);
        }
        private ZaxidnuiHoroscop CalculateWesternSign()
        {

            int month = DateOfBirth.Month;
            int day = DateOfBirth.Day;

            switch (month)
            {
                case 1:
                    return (day <= 19) ? ZaxidnuiHoroscop.Capricorn : ZaxidnuiHoroscop.Aquarius;
                case 2:
                    return (day <= 18) ? ZaxidnuiHoroscop.Aquarius : ZaxidnuiHoroscop.Pisces;
                case 3:
                    return (day <= 20) ? ZaxidnuiHoroscop.Pisces : ZaxidnuiHoroscop.Aries;
                case 4:
                    return (day <= 19) ? ZaxidnuiHoroscop.Aries : ZaxidnuiHoroscop.Taurus;
                case 5:
                    return (day <= 20) ? ZaxidnuiHoroscop.Taurus : ZaxidnuiHoroscop.Gemini;
                case 6:
                    return (day <= 20) ? ZaxidnuiHoroscop.Gemini : ZaxidnuiHoroscop.Cancer;
                case 7:
                    return (day <= 22) ? ZaxidnuiHoroscop.Cancer : ZaxidnuiHoroscop.Leo;
                case 8:
                    return (day <= 22) ? ZaxidnuiHoroscop.Leo : ZaxidnuiHoroscop.Virgo;
                case 9:
                    return (day <= 22) ? ZaxidnuiHoroscop.Virgo : ZaxidnuiHoroscop.Libra;
                case 10:
                    return (day <= 22) ? ZaxidnuiHoroscop.Libra : ZaxidnuiHoroscop.Scorpio;
                case 11:
                    return (day <= 21) ? ZaxidnuiHoroscop.Scorpio : ZaxidnuiHoroscop.Sagittarius;
                default:
                    return (day <= 21) ? ZaxidnuiHoroscop.Sagittarius : ZaxidnuiHoroscop.Capricorn;
            }
        }

        private void AgeCommand()
        {
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.Month < DateOfBirth.Month || (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day))
            {
                age--;
            }
            if (age < 0 || age > 135)
            {
                MessageBox.Show("Date of birth entered incorrectly! Try again.");
                return age = 0;
                
            }
            if (DateTime.Now.Day == DateOfBirth.Day && DateTime.Now.Month == DateOfBirth.Month)
            {
                MessageBox.Show("Happy birthday!");
            }
            return age;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
