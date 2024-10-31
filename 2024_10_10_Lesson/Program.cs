using System;

namespace _2024_10_10_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            long year = 0;
            double someValue = 0.1;
            DateTime nowDate = new DateTime(2015, 10, 15);
            DateTime date = DateTime.Now.AddDays(-25);
            Console.WriteLine(date.Date.ToString("dd.MM.yyyy"));
            Console.WriteLine(nowDate);
            int monthDay = date.Day;

            /*for (int i = 1; i <= monthDay; i++)
            {
                Console.WriteLine("test: " + i + "bruh");
            }*/

            List<string> namesList = new List<string>() { "John", "Doe", "Jane" };
            List<string> lastNamesList = new List<string>();
            namesList.Add("Mihkel");

            System.String[] namesArray = namesList.ToArray();

            foreach (string name in namesList)
            {
                string lastName = "Tamm";
                string nameAndLastName = name + " " + lastName;
                lastNamesList.Add(nameAndLastName);
            }

            foreach (var name in lastNamesList)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}