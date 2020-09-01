using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have? ");
            var _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            if  (_numberOfSiblings < 1)
                Console.WriteLine("Okey. That's cool man.");
            else
            {
                string[] siblings = new string[_numberOfSiblings];

                if (_numberOfSiblings == 1)
                {
                    Console.Write("What's ur siblings name? ");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for (var i=0; i < _numberOfSiblings; i++)
                    {
                        if (i == 0)
                            Console.Write("What's ur first siblings name? ");
                        else
                            Console.Write("And your next siblings name? ");

                        siblings[i] = Console.ReadLine();
                    }
                }


                if (_numberOfSiblings == 1)
                    Console.Write("So correct me if I am wrong. Your sibling is ");
                else
                    Console.Write("So correct me if I am wrong. Your sibling are ");

                foreach(var sibling in siblings)
                {
                    Console.Write($"{sibling} ");
                }
            }
        }
    }
}
