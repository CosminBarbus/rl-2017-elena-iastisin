using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalVoices
{
    class Animal
    {

        string AnimalType;
        string AnimalVoice;

        public Animal(string name, string voice)
        {
            this.AnimalType = name;
            this.AnimalVoice = voice;
        }

        public string GetAnimalType()
        {
            return AnimalType;
        }

        public string GetAnimalVoice()
        {
            return AnimalVoice;
        }
    }

      
}
