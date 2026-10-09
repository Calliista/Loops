using System.Reflection.Emit;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
                //Console.WriteLine("Are we there yet?");
            Random generator = new Random();
            int pin = 12345;
            int entry, die1, die2, tries = 0, pins = 0, count =0;
            bool done = false;

            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.Write("ENTER YOUR PIN:");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();

            while (entry != pin)
            { 
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN:");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            while (done!)
            {
                while (!int.TryParse(Console.ReadLine(), out pins)) ;
                Console.WriteLine("Please enter a valid number");
                tries++;
                if (pins == entry)
                {
                    Console.WriteLine("Pin Accepted.");
                    done = true; //This ends the loop
                }
                else if (tries == 5)
                {
                    Console.WriteLine("Too many inncorrect tries. Access denied.");
                    done = true; //This ends the loop
                }
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            //Questions
            //1.
            //2.
            //3. The error message repeats repeatedly.

            //2. Dice doubles
            Console.WriteLine("Press enter to roll 2 dice");
            Console.ReadLine();
            die1 = generator.Next(1, 7);
            die2 = generator.Next(1, 7);
            while (die1 != die2)
            {
                die1 = generator.Next(1, 7);
                die2 = generator.Next(1, 7);
                Console.WriteLine($"{die1} {die2}");
               
            }
            Console.WriteLine("You got doubles!");

            //
            Console.WriteLine("Type in a message, and I'll desplay it 5 times.");
            Console.Write("Message: ");
            string message = Console.ReadLine();
        }
    }
}
