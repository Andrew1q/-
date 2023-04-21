using System;

class Program {
    static void Main(string[] args) {
        // Введите значения сопротивлений R1, R2, R3
        Console.Write("Введите значение R1: ");
        double r1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение R2: ");
        double r2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение R3: ");
        double r3 = Convert.ToDouble(Console.ReadLine());

        // Рассчитываем общее сопротивление
        double resistance = 1 / ((1 / r1) + (1 / r2) + (1 / r3));

        // Выводим результат
        Console.WriteLine("Общее сопротивление соединения: " + resistance.ToString());
    }
}
