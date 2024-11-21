using System;

/*Siia Võib koodi kirjutada*/

namespace GameRelease

{

    internal class Program

    {

        static void Main(string[] args)

        {

            DateTime latestGameReleaseDate = DateTime.Now.AddYears(-20);

            DateTime futureGameReleaseDate = DateTime.Now.AddDays(167).AddHours(17).AddMinutes(24);

            string latestGameName = "VHK RPG 2";

            string futureGameName = "VHK RPG 3";

            /*Siia Võib koodi kirjutada*/
            string userName = Console.ReadLine();
            DateTime age = DateTime.Parse(Console.ReadLine());

            /* VARIANT 1: If-else viis */
            if (latestGameReleaseDate > age)
            {
                Console.WriteLine("Palju õnne, " + userName + "! Sa oled võitnud “" + futureGameName + "”, mille saad kätte " + futureGameReleaseDate);
            }
            else if (latestGameReleaseDate < age)
            {
                Console.WriteLine("Lgp. " + userName + ", " + futureGameName + " tuleb poodi müügile: " + futureGameReleaseDate);
            }

            /* VARIANT 2: elegantsem ja kiirem switch-case */
            switch (age)
            {
                case DateTime n when n < latestGameReleaseDate:
                    Console.WriteLine("Palju õnne, " + userName + "! Sa oled võitnud “" + futureGameName + "”, mille saad kätte " + futureGameReleaseDate);
                    break;
                default:
                    Console.WriteLine("Lgp. " + userName + ", " + futureGameName + " tuleb poodi müügile: " + futureGameReleaseDate);
                    break;
            }

            Console.ReadKey();

        }

    }

}

