using System;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Вычисление длины окружности и площади круга ===");

            double R;

            if (args.Length > 0 && double.TryParse(args[0], out double argRadius))
            {
                R = argRadius;
                Console.WriteLine($"Радиус R = {R} (из аргумента командной строки)");
            }
            else
            {
                Console.Write("Введите радиус R: ");
                string? input = Console.ReadLine();

                if (!double.TryParse(input, out R) || R < 0)
                {
                    Console.WriteLine("Ошибка: введите корректное неотрицательное число.");
                    return;
                }
            }

            double circumference = 2 * Math.PI * R;
            double area = Math.PI * R * R;

            Console.WriteLine($"\nРезультаты для радиуса R = {R}:");
            Console.WriteLine($"Длина окружности C = 2 * π * R = {circumference:F4}");
            Console.WriteLine($"Площадь круга    S = π * R^2 = {area:F4}");
        }
    }
}