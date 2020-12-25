using System;
using System.Collections.Generic;

namespace Guessing_Game
{
    public class Program
    {
        static List<Person> persons = new List<Person>();
        const bool Show_Answer = true;

        static void Main(string[] args)
        {
            int chanceCount = 0;
            PopulatePersons();

            while (true)
            {
                int choice = MainMenu();
                if (choice == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            while (chanceCount <= 1)
                            {
                                var person = GetRandomPerson();
                                SimpleGuessingGame simpleGuessing = new SimpleGuessingGame(person);
                                if (simpleGuessing.Play())
                                {
                                    if (Show_Answer)
                                    {
                                        Console.WriteLine("You Win Congratulation!!!!");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                }
                                else
                                {
                                    //Console.Clear();
                                    Console.WriteLine("Sorry Person was " + person.getName() + ", You Lose The Game\n");
                                    if (chanceCount < 1)
                                    {
                                        chanceCount++;
                                        Console.WriteLine("This is Your Second Chance, Try Best\n");
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }
                            break;

                        case 2:
                            var _person = GetRandomPerson();
                            RandomHintGame randomHint = new RandomHintGame(_person);
                            if (randomHint.Play())
                            {
                                Console.WriteLine("You Win Congratulation!!!!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry Person was " + _person.getName() + ", You Lose The Game\n");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        case 3:
                            Console.Clear();
                            VeiwParticipants();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 4:


                            break;

                        default:
                            Console.WriteLine("\nInput is Invalid\n");
                            break;
                    }
                }
            }
        }

        static void PopulatePersons()
        {
            persons.Add(new Person("Bill", "has brown eyes", "does not have hat", "male"));
            persons.Add(new Person("Eric", "has brown eyes", "has hat", "male"));
            persons.Add(new Person("Robert", "has blue eyes", "does not have hat", "male"));
            persons.Add(new Person("George", "has brown eyes", "has hat", "male"));
            persons.Add(new Person("Herman", "has green eyes", "does not have hat", "male"));
            persons.Add(new Person("Anita", "has blue eyes", "does not have hat", "female"));
            persons.Add(new Person("Maria", "has green eyes", "has hat", "female"));
            persons.Add(new Person("Susan", "has brown eyes", "does not have hat", "female"));
            persons.Add(new Person("Claire", "has brown eyes", "has hat", "female"));
            persons.Add(new Person("Anne", "has brown eyes", "does not have hat", "female"));
            
        }

        static Person GetRandomPerson()
        {
            Random random = new Random();
            int index = random.Next(1, persons.Count);
            index = index - 1;
            //Console.WriteLine(i);
            return persons[index];
        }

        static int MainMenu()
        {

            Console.WriteLine("Welcome to Guess Who!");
            Console.WriteLine("This is a main menu.");
            Console.WriteLine("Please select an option");

            Console.WriteLine("------------------------------");

            Console.WriteLine("1 - The Simple Guessing Game ");
            Console.WriteLine("2 - The Random Hint Game");
            Console.WriteLine("3 - View all our participants");
            Console.WriteLine("4 - Exist");

            Console.WriteLine("------------------------------");
            Console.Write("Your Choice : ");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
            }
            return choice;
        }

        static void VeiwParticipants()
        {
            Console.WriteLine("Top 10 Participants In This Guessing Game!!");
            int i = 1;
            foreach(var person in persons)
            {
                Console.WriteLine("\n["+ i++ +"]"+person.getName()+"\n"+person.Description());
            }
        }

    }
}
