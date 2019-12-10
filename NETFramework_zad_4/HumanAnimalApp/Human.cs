using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanAnimalApp
{
    class Human
    {
        public string name = "";
        public int age = 0;

        public Human()
        {
            this.name = "asjfj";
            this.age = 20;
        }

        public Human(string x) : this()
        {
            this.name = x;
        }

        public Human(int x)
        {
            this.age = System.DateTime.Today.Year - x;
        }
    }

    class Woman : Human
    {
        public Woman(string x) : base(x) { }

        public void GetVoice(string x)
        {
            Console.WriteLine(x);
        }

        public void GiveBirth(Human p)
        {
            Console.WriteLine("human, age", p.age, this.name);
        }
    }

    class Man : Human
    {
        public Man(string x) : base(x)
        {
            this.age = 24;
        }

        public void GiveVoice(string x)
        {
            Console.WriteLine(x);
        }

        public void GiveBirth(Human p)
        {
            Console.WriteLine("I am a man", p, age, this.name);
        }
    }
}
