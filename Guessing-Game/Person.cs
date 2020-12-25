using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_Game
{
    public class Person
    {
        private string Name { get; set; }
        private string Hat { get; set; }
        private string Eye { get; set; }
        private string Gender { get; set; }

        public Person(){ }

        public string getName()
        {
            return this.Name.ToString();
        }

        public string getHat()
        {
            return this.Hat.ToString();
        }
        public string getEye()
        {
            return this.Eye.ToString();
        }
        public string getGender()
        {
            return this.Gender.ToString();
        }
        public Person(string Name, string Hat, string Eye, string Gender)
        {
            this.Name = Name;
            this.Hat = Hat;
            this.Eye = Eye;
            this.Gender = Gender;
        }

        public string Description()
        {
            return this.Name +" "+ this.Hat + ", " + this.Eye + ", and is a" + this.Gender;
        }
    
    
    
    }
}
