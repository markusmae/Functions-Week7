using System;

namespace UsernameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutaja eesnime esimsest täht
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem kui kolm rida koodi
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            GetUsernameData(userName);
        }

        public static void GetUsernameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
           

        }







    }
}
