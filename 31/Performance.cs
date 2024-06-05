using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Performance
    {
        private string name;
        private int numberBeginning;
        private int numberEnd;

        public Performance() { }
        public Performance(string name, int numberBeginning, int numberEnd)
        {
            Name = name;
            NumberBeginning = numberBeginning;
            NumberEnd = numberEnd;
        }

        public string Name { get => name; set => name = value; }
        public int NumberBeginning { get => numberBeginning; set => numberBeginning = value; }
        public int NumberEnd { get => numberEnd; set => numberEnd = value; }

        public virtual double Func()
        {
            return (double)(numberEnd - numberBeginning) / numberBeginning;
        }
        public virtual void OutPut()
        {
            Console.Write($"Название: {name}; Число зрителей в начале: {numberBeginning}; Число зрителей в конце: {numberEnd}");
        }

    }
}
