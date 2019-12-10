using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanAnimalApp
{
    interface IAnimal
    {
        string Name
        {
            get;
            set;
        }
    }

    abstract class Animal
    {
        public void VoiceAnimal(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }
    }

    class Dog : Animal, IAnimal
    {
        private string name;
        public Dog()
        {
            this.name = "no name";
        }

        public Dog(string x)
        {
            this.Name = x;
        }

        public string Name
        {
            get
            {
                return name + "wow nie name";
            }
            set
            {
                name = value;
            }
        }

        public void Describe(string x)
        {
            Console.WriteLine(x);
        }

        public int CompareTo(object o)
        {
            if (o is IAnimal)
            {
                return this.name.CompareTo((o as IAnimal).Name);
            }
            return 0;
        }

        public override string ToString()
        {
            return this.Name.ToUpper() + "smile dog";
        }
    }

    class Cat : Animal, IAnimal
    {
        private string name;

        public Cat()
        {
            this.Name = "i am only a cat";
        }

        public string Name
        {
            get
            {
                return name + "wow nie name";
            }
            set
            {
                name = value;
            }
        }
    }
}
