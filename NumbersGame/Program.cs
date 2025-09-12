using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace NumbersGame;
//Rasmus Andersen SUT25

class Program
{
    //method to check if your anwser equal to CPU_anwser
    private static bool CheckGuess(int anwser, int CPU_anwser)
    {
        return anwser == CPU_anwser;
    }

    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool PlayAgain = true;



        
        while (PlayAgain)
        {
            //makes cpu anwser to a number between 1-20 randomly
            int CPU_anwser = rnd.Next(1, 20);
            int attempts = 5;
            bool IsCorrect = false;
            int anwser;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            //checks if anwser is correct and if you have attempts
            while (!IsCorrect && attempts > 0)
            {
                anwser = Convert.ToInt32(Console.ReadLine());
                IsCorrect = CheckGuess(anwser, CPU_anwser);

                if (IsCorrect)
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                }
                else
                {

                    attempts--;
                    //tells you if your higher or lower than the CPU anwser
                    if (anwser < CPU_anwser)
                    {
                        Console.WriteLine("För lågt du har " + attempts + " gissningar kvar!");
                    }
                    else
                    {
                        Console.WriteLine("För högt " + attempts + " gissningar kvar!");
                    }
                }

            }
            //if you lose this will print out the CPUs anwser
            if (!IsCorrect)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                Console.WriteLine("Du förlorade. Rätt svar var " + CPU_anwser);
            }

            //to see if you want to play again
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
