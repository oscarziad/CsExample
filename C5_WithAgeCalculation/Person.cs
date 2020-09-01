using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }


        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name} sweet :) ");
        }

        public void AskForAge()
        {
            Console.Write("How old are you man? ");

            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
                //age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");

                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dude are you dumb!");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {Age}.");
            }
        }

        public void NameContains()
        {
            Console.WriteLine($"Dude your name contains {Name.Length} charachters.");
        }

        public void AskForCity()
        {
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {City}.");
        }

        public void AskForDateOfBirth()
        {
            Console.Write("When were you born? ");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, I mean when, like 1999-01-01. So when were you born? ");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid man.");
                }
            }

            Console.WriteLine($"Oh cool man! We are the same age. I am also {CalculateAge()}");

        }

        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfWeek < DateOfBirth.DayOfWeek)
                Age = Age - 1;


            return Age;
                
        }
    }
}
