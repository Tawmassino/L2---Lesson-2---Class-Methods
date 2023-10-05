using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class Human //class
    {
        //PROPERTIES
        public string FirstName { get; set; } // property - string
        public string LastName { get; set; }
        public int Age { get; set; } // property - int

        public string Email { get; set; } // property - string
        public string EmailAlternative { get; set; } = "tuscias@gmail.com"; //galim priskirti default reiksme

        // public List<Pet> Pets { get; set; } // property - List //reikia butinai is karto inicializuoti lista, nepalikti tuscio
        public List<Pet> Pets { get; set; } = new List<Pet>(); //arba galime taip daryti, ir nedaryti atskirai konstruktoriuje


        //CONSTRUCTOR
        public Human(string firstName, string lastName, int age)
        {//set parameter to property

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            //Pets = new List<Pet>(); //sukuriame List tuscia cia, nes prideti kazka i lista galim, jei listas tuscias, bet ne NULL
            //cia apibreziant new List, sukuriame tuscia lista

        }
        // ====================== class methods ======================
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void UpdateEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))//metode kvieciam kita private metoda
            {
                Email = newEmail;//setting property
            }
            else
            {
                Console.WriteLine("ivestas nevalidus emailas");
            }
        }

        private bool IsValidEmail(string newEmail)
        {
            var regexPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            return Regex.IsMatch(newEmail, regexPattern);
        }

        public void PrintPets()
        {
            foreach (var pet in Pets) { Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}"); }
        }

        public void PrintPets(string animalType)
        {
            foreach (var pet in Pets)
            {
                if (pet.AnimalType == animalType)
                {
                    Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
                }

            }

        }

        // ====================== end of class methods ======================
    }

}
