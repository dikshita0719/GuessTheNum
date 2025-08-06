using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {

        /*this is a  program that makes the user guess a number(or a name ) 
         * and the user has three chances to do so. if you guess it right, you win something.
         * if you run out of guesses, the game is over and you can 
         * choose if u want to play again or leave
         */
        int TheNum = 24;
        int chance = 0;
        bool again = true;
        do
        {
            Console.WriteLine("Guess the number: ");
            int myNum = Convert.ToInt32(Console.ReadLine());

            if (myNum == TheNum)
            {
                Console.WriteLine("You Win! You should try telepathy or smth");
                again = false;
            }
            else
            {
                chance++;
                if (chance >= 3)
                {
                    Console.WriteLine("Loser!!!");
                    Console.WriteLine();
                    Console.WriteLine("Again?(j/n)");
                    string ans = Console.ReadLine();
                    if (ans == "j")
                    {
                        again = true;
                    }
                    if (ans == "n")
                    {
                        again = false;
                    }
                }
            }

        } while (again == true);

    }

}
