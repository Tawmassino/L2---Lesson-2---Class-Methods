using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class Pet
    {//PROPERTIES
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Sound { get; set; }

        //CONSTRUCTOR
        public Pet(string animalType, string name, int age, string sound)
        {
            AnimalType = animalType;
            Name = name;
            Age = age;
            Sound = sound;

        }

        public void MakeSound()
        {
            Console.WriteLine($"My sound is {Sound}");
        }
    }
}
