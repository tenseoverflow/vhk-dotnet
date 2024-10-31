namespace pikkus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma pikkus sentimeetrites:");
            string input1 = Console.ReadLine();

            float pikkus = float.TryParse(input1, out pikkus) ? pikkus : -1;

            if (nimi == "")
            {
                nimi = "tundmatu";
            }

            if (pikkus > 200)
            {
                Console.WriteLine("Oh sa poiss! " + nimi + ", sa oled ikka pikk küll!");
            }
            else if (pikkus <= 0)
            {
                Console.WriteLine("Palun sisesta korrektne pikkus.");
            }
            else
            {
                Console.WriteLine("Tere, " + nimi + ", sinu pikkus on " + pikkus + "cm.");
            }
        }
    }
}