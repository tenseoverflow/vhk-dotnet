namespace onju_nii
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Onju nii?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "jah":
                    Console.WriteLine("Selge too siis homme 100 eurot.");
                    break;
                case "ei":
                    Console.WriteLine("No kui sa ei taha palka, siis võime seekord selle vahele jätta.");
                    break;
                default:
                    Console.WriteLine("Sa vist ei saanud küsimusest aru.");
                    break;
            }
        }
    }
}