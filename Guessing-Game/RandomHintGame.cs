using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_Game
{
    public class RandomHintGame : Game
    {
        private string randomHint;
        private List<string> charactertics = new List<string>();

        public RandomHintGame(Person person)
        {
            this.person = person;
            charactertics.Add("This Person " + this.person.getHat()+".");
            charactertics.Add("This Person " + this.person.getEye() + "." );
            charactertics.Add("This Person " + this.person.getGender() + ".");

            Random random = new Random();
            int index = random.Next(1, charactertics.Count);
            index = index - 1;
            randomHint = charactertics[index];
        }

        public bool Play()
        {
            Console.WriteLine("\n[*]Your Hint : "+randomHint);
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
