namespace ConsoleApp1
{
    internal class Program
    {
        public static float Calculate(int number1, string calc, int number2)
        {
            switch (calc)
            {
                case "+":
                case "pluss":
                    return number1 + number2;
                case "-":
                case "miinus":
                    return number1 - number2;
                case "*":
                case "korrutamine":
                    return number1 * number2;
                case "/":
                case "jagamine":
                    return number1 / number2;
                default:
                    throw new Exception("Sellist kalkulatsiooni ei ole olemas");
            }
        }

        private static void Main(string[] args)
        {
            string calc = string.Empty;
            int number1 = 0;
            int number2 = 0;

            bool workingNumber1 = true;
            while (workingNumber1)
            {
                try
                {
                    Console.WriteLine("Sinu esimene number:");
                    number1 = int.Parse(Console.ReadLine());
                    workingNumber1 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Viga: Palun sisesta täisarv");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                }
            }

            bool workingCalc = true;
            while (workingCalc)
            {

                Console.WriteLine("Mis kalkulatsiooni teeme (pluss, miinus, korrutamine, jagamine):");
                calc = Console.ReadLine();

                if (calc == "+" || calc == "pluss" || calc == "-" || calc == "miinus" || calc == "*" || calc == "korrutamine" || calc == "/" || calc == "jagamine")
                {
                    workingCalc = false;
                }
                else
                {
                    Console.WriteLine("Sellist kalkulatsiooni ei ole olemas.");
                }

            }

            bool workingNumber2 = true;
            while (workingNumber2)
            {
                try
                {
                    Console.WriteLine("Sinu teine number:");
                    number2 = int.Parse(Console.ReadLine());
                    workingNumber2 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Viga: Palun sisesta täisarv");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                }
            }

            try
            {
                Console.WriteLine("Vastus: " + Calculate(number1, calc, number2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nulliga jagada ei saa");
            }
            catch (Exception e)
            {
                Console.WriteLine("Viga: " + e.Message);
            }
        }
    }
}