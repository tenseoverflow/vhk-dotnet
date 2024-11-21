using System;

/*Siia võib koodi kirjutada*/

namespace WhatsUp

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Tere! Mis teed ?");

            /*Siia võib koodi kirjutada*/
            string input = Console.ReadLine();

            switch (input)
            {
                case "lollitan":
                    for (int i = 1; i <= 250; i++)
                    {
                        Console.WriteLine("Kas nii vä? :P");
                    }
                    break;
                default:
                    Console.WriteLine(DateTime.Now + " Masin registeeris tegevuse: " + input);
                    break;
            }

            Console.ReadKey();

        }

    }

}