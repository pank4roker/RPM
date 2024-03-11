using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>();
            addresses.Add(new Address("Paris","Петровская",34,77520915,"Kirill","Markow","Alecs"));
            foreach (Address address in addresses) 
            {
                address.Info();
            }
            Write("Введите Адрес/Фио/Адрес или ФИО: ");
            string dan = ReadLine();
            foreach (Address address in addresses) 
            {
                address.Vibor(dan);
            }
            ReadKey();
        }
    }
}
