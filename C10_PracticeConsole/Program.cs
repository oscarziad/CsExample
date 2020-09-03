using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace C10_PracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            bool _hasCars;

            Console.Write("Hello Dear, Do you have any cars? (Yes/No) ");
            var _carResponse = Console.ReadLine();

            switch (_carResponse.ToLower())

            {
                case "yes":
                    _hasCars = true;
                    break;

                case "no":
                    _hasCars = false;
                    break;

                default:
                    _hasCars = false;
                    break;
            }

            if (!_hasCars)
                Console.WriteLine("That's awesome for the enviorment! ");
            else
            {
                Console.Write("So cool, so how many cars do got?");
                int _totalCars = Convert.ToInt32(Console.ReadLine());

                var cars = new List<string>();

                if (_totalCars == 1)
                {
                    Console.Write("Cool, so what brand is the car? ");
                    cars.Add(Console.ReadLine());

                    Console.WriteLine($"I love it, {cars[0]} has great cars!");
                }
                else
                {
                    Console.Write("So what car brands do you own? Seperate with (,)");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach (var name in names)
                    {
                        cars.Add(name);                    
                    }

                    Console.Write("Which of your cars are the oldest one? ");
                    var _oldest = Console.ReadLine();

                    var index = cars.FindIndex(x => x.Contains(_oldest));
                    cars.RemoveAt(index);
                    cars.Insert(0, _oldest);

                    Console.Write($"Okey, so you own a ");
                    foreach (var car in cars)
                    {
                        Console.Write($"{car} ");
                    }
                }
            }

        }
    }
}
