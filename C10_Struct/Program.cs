using System;

namespace C10_Struct
{



    class ClassExample 
    {
    public int Num1 { get; set; }
    public int Num2 { get; set; }

        public ClassExample(int num1, int num2) 
        {
            Num1 = num1;
            Num2 = num2;
        
        }

        public void DisplayValues() 
        {
            Console.WriteLine($"Display values: {Num1}-{Num2}");
        }

    }

    struct structExample
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public structExample(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;

        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display values: {Num1}-{Num2}");
        }

    }


    class Program
    {


        private static void ModifyValues(dynamic d) 
        {
            d.Num1 += 1;
            d.Num2 += 1;

            Console.WriteLine($"ModifingValues:{d.Num1}{d.Num2}");
        
        }

        static void Main(string[] args)
        {

            Console.WriteLine();
            var classexample = new ClassExample(1, 1);
            classexample.DisplayValues();
            ModifyValues(classexample);
            classexample.DisplayValues();

            Console.WriteLine("--------------------------------------");


            Console.WriteLine();
            var structexample = new structExample(1, 1);
            structexample.DisplayValues();
            ModifyValues(structexample);
            structexample.DisplayValues();

        }
    }
}
