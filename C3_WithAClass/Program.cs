using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome Dude! What's your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"{person.Name} sweet :) How old are you man? ");

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
                //age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");

                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dude are you dumb!");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {person.Age}.");
            }

            Console.WriteLine($"Dude your name contains {person.Name.Length} charachters.");
            Console.Write($"{person.Name} where do you live? ");
            person.City = Console.ReadLine();


            Console.WriteLine($"Sweet! My brother lives in {person.City}.");
        }
    }
}
