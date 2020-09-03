using System;

namespace C11_Enum
{
    public enum Level                           
    {
    Low,
    Normal,
    High
    }

    class Program
    {
        public enum Status 
        {
        Pending,
        Production,
        Transporing,
        Delivering
        }

        static void Main(string[] args)
        {
            var temperatur = 14;
            var _tempLevel = Level.Normal;

            switch (temperatur)
            { 
                case int t when t < 10:
                    _tempLevel = Level.Low;
                    Console.WriteLine("Temp is to low.");
                    break;
                case int t when t > 30:
                    _tempLevel = Level.High;
                    Console.WriteLine("Temp is to high.");
                    break;
                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temp is normal.");
                    break;
                        

            }

            switch (_tempLevel)
            {
                case Level.Low:
                    Console.WriteLine("Temp is to low.");
                    break;
                case Level.Normal:
                    break;
                case Level.High:
                    Console.WriteLine("Temp is to high.");
                    break;
                default:
                    Console.WriteLine("Temp is normal.");
                    break;
            }


            var status = Status.Transporing;

                switch (status)

                {
                case Status.Pending:
                    Console.WriteLine("Order is Pending");
                    break;
                case Status.Production:
                    Console.WriteLine("Order is in production");
                    break;
                case Status.Transporing:
                    Console.WriteLine("Order is under transport");
                    break;
                case Status.Delivering:
                    Console.WriteLine("Order is deliverd");
                    break;
                default:
                    Console.WriteLine("Order not found");
                    break;
                }



        }
    }
}
