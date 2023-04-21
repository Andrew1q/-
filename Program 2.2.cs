using System;
namespace project {
    class Program {
        static void Main() { 
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y <= 0)
                System.Console.WriteLine("Принадлежит");
            else System.Console.WriteLine("Не принадлежит");
        }
    }
}
