using SukailoCSharp01.SignsOfHoroscop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukailoCSharp01.Models
{
    internal class UserInf
    {
        private int _age;
        private DateTime _dateOfBirth = DateTime.Today;
        private ZaxidnuiHoroscop _westernSign;
        private ChineseHoroscop _chineseSign;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public ZaxidnuiHoroscop WesternSign
        {
            get { return _westernSign; }
            set { _westernSign = value; }
        }
        public ChineseHoroscop ChineseSign
        {
            get { return _chineseSign; }
            set { _chineseSign = value; }
        }
    }
}
