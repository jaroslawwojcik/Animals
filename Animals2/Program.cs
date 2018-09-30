using Animals2.Interfaces;
using Animals2.Models;
using Animals2.Repositories;
using System;
using System.Collections.Generic;

namespace Animals2
{
    class Program
    {
        private static AnimalRepository animalsList = new AnimalRepository();

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Menu();
                var switchOption = Console.ReadKey(true).Key;
                MainMenu(switchOption);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }

        static void Menu()
        {
            Console.WriteLine("Hello to my little program");
            Console.WriteLine("Please choose option");
            Console.WriteLine("1) Add Animal");
            Console.WriteLine("2) Display Animals");
            Console.WriteLine("Press esc twice to exit");
        }

        static void CreateAnimal(ConsoleKey option)
        {
            Console.Clear();
            IAnimal animal;
            switch (option)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Creating Cat!");
                    animal = new Cat();
                    animalsList.AddAnimalToList(animal);
                    animal.Speak();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Creating Dog!");
                    animal = new Dog();
                    animalsList.AddAnimalToList(animal);
                    animal.Speak();
                    break;
                default:
                    Console.WriteLine("Please choose between 1 and 2 to create animal");
                    break;
            }
            
        }
        static void MainMenu(ConsoleKey option)
        {
            Console.Clear();
            switch (option)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Press 1 to create a cat or 2 to create a dog");
                    var switchOption = Console.ReadKey(true).Key;
                    CreateAnimal(switchOption);
                    break;
                case ConsoleKey.D2:
                    PrintNrInPopulation(animalsList.GetList());
                    break;
                default:
                    Console.WriteLine("Please press any key to go back and choose between 1 and 2 to do action or esc to exit");
                    break;
            }

        }

        private static void PrintNrInPopulation(List<IAnimal> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                var animal = list[i];
                var animalType = animal.GetType().Name.ToString();
                Console.WriteLine($"This is {animalType} with number {i+1}");
                animal.Speak();
                
                
            }
        }
    }
}
