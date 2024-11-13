using System.Runtime.InteropServices;

namespace veejoomine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kuu number");
            int kuu = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta aasta number");
            int aasta = int.Parse(Console.ReadLine());

            int paevad = DateTime.DaysInMonth(aasta, kuu);

            List<float> tarbimine = new List<float>() { };

            for (int i = 1; i <= paevad; i++)
            {
                DateTime date = new DateTime(aasta, kuu, i);
                tarbimine.Add(new Random().Next(5, 300));

                Console.WriteLine(date.ToString("d") + " tarbisite " + tarbimine[i - 1] + " liitrit vett.");
            }

            Console.WriteLine("Kuus tarbisite kokku " + tarbimine.Sum() / 1000 + " kuupmeetrit vett.");

        }
    }
}