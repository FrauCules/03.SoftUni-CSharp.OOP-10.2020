using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Demo_IsKeyword
{
    class Human
    {
        public Human(Animal pet)
        {
            Pet = pet;
        }

        public Animal Pet { get; set; }

        public void Feed()
        {
            if(Pet is Snake)
            {
                ((Snake)Pet).EatPerson(this);   // кастване Up
                (Pet as Snake).EatPerson(this); // кастване Down

                Snake snake = Pet as Snake;

                //Console.WriteLine("Храня змията");    
                return;
            }
            Pet.Eat("Нахрани се.");
        }

        public void PutToSleep()
        {
            Pet.Sleep();
        }
    }
}
