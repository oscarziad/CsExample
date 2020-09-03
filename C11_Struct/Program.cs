using System;

namespace C11_Struct
{
    // Minneshantering (RAM-HDD)
    // HEAP     = Långsammare   MALOC() FREE()    CLASS
    // STACK    = Snabbare                        STRUCT    stack overflow

    struct StructExample
    {
        public int Nr1 { get; set; }

        public int Nr2 { get; set; }

        public StructExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }

    struct ClassExample
    {
        public int Nr1 { get; set; }

        public int Nr2 { get; set; }

        public ClassExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }


    class Program
    {
        private static void ModifyValues(dynamic d)
        {
            d.Nr1 += 1;
            d.Nr2 += 1;

            Console.WriteLine($"Modifying Values: {d.Nr1},{d.Nr2}");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("ClassExample - HEAP (GLOBAL)");
            var classexample = new ClassExample(1, 1);

            classexample.DisplayValues();
            ModifyValues(classexample);
            classexample.DisplayValues();

            Console.WriteLine("\n--------------------------------\n");

            Console.WriteLine("StructExample - STACK (LOCAL)");
            var structexample = new StructExample(1, 1);

            structexample.DisplayValues();
            ModifyValues(structexample);
            structexample.DisplayValues();


            Console.ReadKey();
        }

        /*
            int Nr1 = 1      -> Global
            int Nr2 = 1      -> Global

            function {
            
            Nr1(Copy) = 2    -> Local
            Nr2(Copy) = 2    -> Local
                
            }

            Nr1 == 2
            Nr2 == 2
        */
    }
}
