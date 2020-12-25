using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_Game
{
    class SimpleGuessingGame : Game
    {
        public SimpleGuessingGame(Person person)
        {
            this.person = person;
        }
        public bool Play()
        {
            Console.Write("\nInput a name to try and guess who the random person is : ");
            string name = Console.ReadLine();

            if (name.ToLower() == person.getName().ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
