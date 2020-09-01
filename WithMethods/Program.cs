using System;

namespace WithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.AskForName();
            person.AskForAge();
            person.AskForCity();
        }
    }
}
