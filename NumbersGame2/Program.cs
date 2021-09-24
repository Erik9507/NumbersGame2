using System;           //SUT21 Erik Norell

namespace NumbersGame2
{
    class Program
    {
        static void myMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nVälkommen till nummerspelet! Välj nedan i menyn.");
            Console.WriteLine("\n[1] spela");
            Console.WriteLine("\n[2] ändra svårighetsgrad");
            Console.WriteLine("\n[3] avsluta spelet.");
        }
        static void Main(string[] args)
        {
            bool game = true;
            int randomNum = 20;

            while (game)
            {
                Console.Clear();
                myMenu();
                int menu;
                int.TryParse(Console.ReadLine(), out menu);
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        int allowedGuess = 0;
                        Random num = new Random();
                        int number = num.Next(1, randomNum);
                        Console.WriteLine("Välkommen, jag tänker på ett nummer mellan 1 och " + randomNum);
                        Console.WriteLine("Kan du gissa vilket? Du får 5 gissningar.");
                        while (allowedGuess != 5)
                        {
                            int guess;
                            int.TryParse(Console.ReadLine(), out guess);
                            allowedGuess++;
                            if (guess == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Du måste skriva en siffra mellan 1 och " + randomNum);
                                allowedGuess = 0;
                            }
                            else

                            if (guess == number)
                            {
                                Console.WriteLine("Grattis, du har vunnit");
                                Console.WriteLine("Vill du spela igen? ja/nej?");
                                string answ1 = Console.ReadLine();
                                if (answ1.ToLower() == "ja")
                                {
                                    randomNum = 20;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Tack för att du har spelat");
                                    game = false;
                                    Console.Clear();

                                }
                            }
                            else if (guess > number)
                            {
                                Console.WriteLine("nummret är lägre än " + guess);
                            }
                            else if (guess < number)
                            {
                                Console.WriteLine("numret är högre än " + guess);
                            }

                        }
                        while (allowedGuess >= 5)
                        {
                            Console.WriteLine("Du har tyvärr förlorat!");
                            Console.WriteLine("Rätt svar var: " + number);
                            Console.WriteLine("Vill du spela igen? ja/nej?");
                            string answ2 = Console.ReadLine();
                            if (answ2.ToLower() == "ja")
                            {
                                randomNum = 20;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tack för att du har spelat");
                                game = false;
                                Console.Clear();

                            }

                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hur många siffror vill du gissa på?");
                        int.TryParse(Console.ReadLine(), out randomNum);
                        break;
                    case 3:
                        game = false;
                        break;
                }
            }
        }
    }
}
