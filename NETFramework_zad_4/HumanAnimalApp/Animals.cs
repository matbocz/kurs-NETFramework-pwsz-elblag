using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanAnimalApp
{
    class Animals
    {
        internal static void DoAnimal()
        {
            Dog dog1 = new Dog("gusio");
            Dog o2 = new Dog("bobik");
            Dog dog3 = new Dog();

            dog3.VoiceAnimal(1000, 500);
            Console.WriteLine(dog1.Name);
            Console.WriteLine(dog1.ToString());

            Cat o4 = new Cat();
            Console.WriteLine(o4.Name);
            Console.WriteLine(o4.ToString());

            if (o2.GetType() == typeof(Animal))
            {
                o2.VoiceAnimal(1000, 1000);
            }

            if (o4.GetType() == typeof(Animal))
            {
                o4.VoiceAnimal(700, 500);
            }
        }
    }
}
