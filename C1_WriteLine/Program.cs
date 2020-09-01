using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\user\Oscar\Documents\ducument.txt";
            var path2 = "c:\\user\\Oscar\\Documents\\ducument.txt";

            string name = "Oscar";
            int age = 19;
            string city = "Stockholm";

            var text1 = "Welcome Oscar. You are 19 years old right? Oscar do you live in Stockholm?";

            var text2 = "Welcome " + name + ". You are " + age + " years old right? " + name + " do you live in " + city + "?";
            var text3 = String.Format("Welcome {0}. You are {1} years old right? {0} do you live in {2}?", name, age, city);

            var text4 = $"Welcome {name}. You are {age} years old right? {name} do you live in {city}?";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);

        }
    }
}
