using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_ClassExercise_OOP_Animal
{
    class Animal
    {

        private int legs { get; set; }
        private int arms { get; set; }
        private string type { get; set; }
        public string name { get; private set; }
        private bool isDangerous { get; set; }

        public Animal(int legs, int arms, string type, string name, bool isDangerous)
        {
            // Note: "this" references the Animal class. Used with a period (.) 
            // the Property is referenced and doesn't get mixed up with the constructor 
            // arg with the same name.

            this.legs = legs;
            this.arms = arms;
            this.type = type;
            this.name = name;
            this.isDangerous = isDangerous;

        }
        public void Walk()
        {
            Console.WriteLine($"{this.name} just walked across the floor.");
        }

        public string GetNumberOfLegsStatementForAnimal3()
        {
            string strReturn = string.Empty;

            strReturn = $"{this.name} has {this.legs} legs.";

            return strReturn;

        }

    }
}
