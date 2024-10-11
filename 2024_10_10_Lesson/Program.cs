using System;

namespace _2024_10_10_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            long year = 0;
            double someValue = 0.1;
            DateTime date = DateTime.Now.AddDays(-25);
            Console.WriteLine(date.Date.ToString("dd.MM.yyyy"));
            Console.ReadKey();
        }
    }
}