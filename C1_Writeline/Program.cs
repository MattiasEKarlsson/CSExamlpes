using System;


namespace C1_Writeline
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mattias";
            int age = 36;
            bool isrunning = true;
            var city = "Örebro";
            var path = @"D:\Vuze\matte.txt";

            var text1 = $"Welcome {name}. You are {age} old right? {name} do u live in {city} ";  
            var text3 = String.Format("Hej {0} ,du är {1} år gammal och bor i {2}.", name, age, city);

            Console.WriteLine($"{isrunning}-{name}-{city}-{age}");
            Console.WriteLine(text1);
            Console.WriteLine(text3);
        }
    }
}


