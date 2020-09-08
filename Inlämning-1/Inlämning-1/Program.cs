using System;

namespace Labb4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            start_of_loop:
            int val = r.Next(1, 100);
            int guess = 0;
            bool correct = false;
            int count = 0;
            

            Console.WriteLine("Gissa ett tal mellan 1 - 100!");

            while (!correct)
            {
                Console.Write("Gissa: ");
                string input = Console.ReadLine();
                count++;
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Det där är ingen siffra ...");
                    continue;
                }


                if (guess < val)
                {
                    Console.WriteLine($"Talet är högre, prova igen!");
                }
                else if (guess > val)
                {
                    Console.WriteLine($"Talet är lägre, prova igen!");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine($"Du har gissat rätt! Det tog dig {count} försök. Vill du spela igen? J/N");
                        string svar = Console.ReadLine().ToUpper();
                        if (svar == "J")
                            goto start_of_loop;
                        if (svar == "N")
                            return;
                    }


                }

            }



        }

    }
}
