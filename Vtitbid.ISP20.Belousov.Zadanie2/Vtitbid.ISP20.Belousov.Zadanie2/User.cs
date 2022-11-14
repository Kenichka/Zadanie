using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Belousov.Zadanie2
{
    public class User
    {
        private string _name;
        private string _numberPhone;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string NumberPhone
        {
            get
            {
                return _numberPhone;
            }
            set
            {
                _numberPhone = value;
            }
        }
        public User(string name, string numberPhone)
        {
            Name = name;
            NumberPhone = numberPhone;
        }
        public override string ToString()
        {
            return ($"Имя: {Name} Номер телефона: {NumberPhone}");
        }
    }
}
