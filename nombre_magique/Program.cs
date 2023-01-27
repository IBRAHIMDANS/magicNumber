using System;

namespace magicNumber
{
    class Program
    {
        static int AskNumber(int min, int max)
        {
            int inputUser = max + 1;

            while ((inputUser < min) || (inputUser > max))
            {
                Console.Write($"Rentrez un nombre entre {min} et {max} ");
                string reponse = Console.ReadLine();

                try
                {
                    inputUser = int.Parse(reponse);

                    if ((inputUser < min) || (inputUser > max))
                    {
                        Console.WriteLine($"ERREUR : le nombre doit être entre {min} et {max}");
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide");
                }
            }

            return inputUser;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NumberMin = 1;
            const int NumberMax = 10;
            int MagicNumber = rand.Next(NumberMin, NumberMax+ 1);


            int nombre = MagicNumber + 1;

            int maxLife = 4;

            while (maxLife > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + maxLife);
                nombre = AskNumber(NumberMin, NumberMax);

              
                if (MagicNumber > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (MagicNumber < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
                maxLife--;
            }

            if (maxLife == 0) 
            { 
                Console.WriteLine($"Vous avez perdu, le nombre magique était : {MagicNumber}");
            }
            
          }
    }
}
