using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8pr
{
    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberFlat { get; set; }
        public int NumberPhone { get; set; }
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Otch { get; set; }
        public Address() { }
        public Address(string city, string street, int numberFlat, int numberPhone, string name,string surname, string otch)
        {
            City = city;
            Street = street;
            NumberFlat = numberFlat;
            NumberPhone = numberPhone;
            Name = name;
            Surname = surname;
            Otch = otch;
        }
        public void Info()
        {
            WriteLine($"{City} {Street} {NumberFlat} {NumberPhone} {Name} {Surname} {Otch}");
        }
        public void Vibor(string dan)
        {
            if (Name == dan )
            {
                WriteLine($"{City}{Street}{NumberFlat}");
            }
            else if(Surname == dan)
            {
                WriteLine($"{City}{Street}{NumberFlat}");
            }
            else if (City == dan && Street == dan && Convert.ToString(NumberFlat) == dan)
            {
                WriteLine($"{Name} {Surname} {Otch}");
            }
            else 
            {
                WriteLine($"{City}{Street}{NumberFlat}{Name} {Surname} {Otch}");
            }
        }

    }
}
