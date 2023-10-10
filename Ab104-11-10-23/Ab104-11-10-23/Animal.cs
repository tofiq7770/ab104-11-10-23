using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_11_10_23
{
    internal class Animal
    {
        public string _gender;

        public DateTime _birthDate;//private elemedimki bunu program.cs de cagirib baxa bilesiz, birde method yazmadim.

        public string Gender {
            get
            {
                return _gender;
            } 
            set 
            {
                _gender = value;
            }
        }
        private DateTime BirthDate { 
            get 
            { 
                return _birthDate;
            }
            set
            {
                _birthDate = DateTime.Now;
            }
        }
    }
}
