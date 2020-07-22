using System;

namespace Lesson6_ClassExercise_OOP_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson6_ClassExercise_OOP_Animal!");

            // Declare and Instantiate the Animal class with different arguments...added by th 07042020
            Animal animal1 = new Animal(4, 0, "Dog", "Max", true);
            Animal animal2 = new Animal(2, 2, "Monkey", "Tim", false);
            Animal animal3 = new Animal(8, 0, "Spider", "Friendly the Spider", true);

            Console.WriteLine($"Animal Names: {animal1.name} , {animal2.name} , {animal3.name}");

            animal3.Walk();

            Console.WriteLine(animal3.GetNumberOfLegsStatementForAnimal3());

        }
    }
}
