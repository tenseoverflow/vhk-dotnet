namespace kassiAndmed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Kass> kassid = new List<Kass>();

            Console.WriteLine("Sisesta kasside arv");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Sisesta kassi nimi");
                string nimiInput = Console.ReadLine();

                Console.WriteLine("Sisesta kassi kaal");
                int kaalInput = int.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta kassi sünniaeg (yyyy-MM-dd)");
                DateTime sunniaegInput = DateTime.Parse(Console.ReadLine());

                Kass kassTemp = new Kass(nimiInput, kaalInput, sunniaegInput);

                kassid.Add(kassTemp);
            }

            foreach (Kass kass in kassid)
            {
                Console.WriteLine("\nKass " + kassid.IndexOf(kass) + 1);
                Console.WriteLine("Kassi nimi: " + kass.nimi);
                Console.WriteLine("Kassi kaal: " + kass.kaal);
                Console.WriteLine("Kassi sünniaeg: " + kass.sunnipaev);
                Console.WriteLine("Kassi kood: " + kass.kood);
            }
        }
    }

    class Kass
    {
        public string nimi;
        public int kaal;
        public int kood;
        public DateTime sunnipaev;

        public Kass(string nimi, int kaal, DateTime sunnipaev)
        {
            this.nimi = nimi;
            this.kaal = kaal;
            this.sunnipaev = sunnipaev;
            this.kood = new Random().Next(1000, 9999);
        }
    }
}