using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanAnimalApp
{
    class Program
    {
        delegate void delegat(string x);

        static void Main(string[] args)
        {
            Animals.DoAnimal();

            Woman w1 = new Woman("Woman");
            Man m1 = new Man("Man");
            Dog d1 = new Dog();

            delegat del1 = new delegat(w1.GetVoice);
            delegat del2 = new delegat(m1.GiveVoice);
            delegat del3 = new delegat(d1.Describe);

            del1("\nwoman voice");
            del2("man voice");
            del3("dog describe\n");

            delegat del4 = new delegat(d1.Describe);
            del4 += m1.GiveVoice;
            del4 += d1.Describe;

            del4("woman voice, man voice, dog describe");
        }
    }
}
