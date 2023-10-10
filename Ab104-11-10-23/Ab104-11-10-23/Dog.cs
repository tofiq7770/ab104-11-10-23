using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_11_10_23
{
    internal class Dog : Animal
    {
        public string _name;
        public string _breed;

        public string Name { get; set; }
        private string Breed {
            get
            {
                return _breed;
            }
            set
            {
                _breed = "Golden Retriever";
            }
        }

    }
}
