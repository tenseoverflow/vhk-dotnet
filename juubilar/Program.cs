namespace juubilar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma vanus:");
            var input = Console.ReadLine();
            int age = int.TryParse(input, out age) ? age : -1;

            if (age < 50 && age > 0)
            {
                Console.WriteLine("Kõik hästi!");
            }
            else if (age == 50)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Hurraa juubilar!");
                }
            }
            else if (age > 50)
            {
                Console.WriteLine("Väärikas kodanik!");
            }
            else
            {
                Console.WriteLine("Palun sisesta korrektne vanus täisarvudes.");
            }
        }
    }
}