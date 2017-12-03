using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalVoices
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal1 = new Animal("Cat", "meao-meao");
            Animal animal2 = new Animal("Dog", "woof-woof");
            Animal animal3 = new Animal("Cow", "moo-moo");

            List<Animal> Animals = new List<Animal>
            {
                animal1,
                animal2,
                animal3
            };

            foreach (Animal item in Animals)
            {
                Console.WriteLine("{0} make {1}", item.GetAnimalType(), item.GetAnimalVoice());

            }
            Console.ReadKey();
        }
    }
}
