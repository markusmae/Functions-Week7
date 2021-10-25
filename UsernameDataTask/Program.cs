using System;

namespace UsernameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutajalt numbrit 1 - 3
            //kui kasutaja siestab 1, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse  kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string eesnimi = Console.ReadLine();

            Console.WriteLine("Vali number 1 - 3:");
            int valik = Convert.ToInt32(Console.ReadLine());

            switch(valik)
            {
                case 1:
                tagurpidi(eesnimi);
                break;

                case 2:
                esimene(eesnimi);
                break;

                case 3:
                pikkus(eesnimi);
                break;

                default:
                Console.WriteLine("Kena päeva!");
                break;
                          
            }


                        
        }

        public static void tagurpidi (string eesnimi)
        {
            for (int i= eesnimi.Length -1; i >= 0; i--)
            {
                Console.Write(eesnimi[i]);
            }
        }

        public static void esimene (string eesnimi)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {eesnimi [0]}.");
        }

        public static void pikkus (string eesnimi)
        {
            Console.WriteLine($"Sinu eesnimi on {eesnimi.Length} sümbolit pikk.");
        }

    }
}
