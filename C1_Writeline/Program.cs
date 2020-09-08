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
            

            Console.WriteLine($"{isrunning}-{name}-{city}-{age}");
            Console.WriteLine(text1);
            
    }
}


