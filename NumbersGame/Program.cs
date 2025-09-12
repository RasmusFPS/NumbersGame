using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace NumbersGame;

class Program
{
    private static bool CheckGuess(int anwser, int AI_anwser)
    {
        return anwser == AI_anwser;
    }

    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool PlayAgain = true;




        while (PlayAgain)
        {
            int AI_anwser = rnd.Next(1, 20);
            int attempts = 5;
            bool IsCorrect = false;
            int anwser;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            while (!IsCorrect && attempts > 0)
            {
                anwser = Convert.ToInt32(Console.ReadLine());
                IsCorrect = CheckGuess(anwser, AI_anwser);

                if (IsCorrect)
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                }
                else
                {

                    attempts--;

                    if (anwser < AI_anwser)
                    {
                        Console.WriteLine("För lågt du har " + attempts + " gissningar kvar!");
                    }
                    else
                    {
                        Console.WriteLine("För högt " + attempts + " gissningar kvar!");
                    }
                }

            }

            if (!IsCorrect)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                Console.WriteLine("Du förlorade. Rätt svar var " + AI_anwser);
            }

            Console.WriteLine("Vill du spela igen? ja/nej");
            string input = Console.ReadLine().ToLower();

            if (input != "ja")
            {
                PlayAgain = false;
            }
            else
            {
                Console.Clear();
            }
        }

        Console.WriteLine("Tack för att du spelade! Hej då.");

    }


}
