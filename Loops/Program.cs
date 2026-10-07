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
            int entry;

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

            //Questions
            //1.
            //2.
            //3. The error message repeats repeatedly.


            Console.WriteLine("Press enter to roll 2 dice");
            Console.ReadLine();
            int die1 = generator.Next(1, 7);
            int die2 = generator.Next(1, 7);
            Console.WriteLine(die1);
            Console.WriteLine(die2);
            Console.WriteLine();
            Console.WriteLine($"{die1} + {die2} = {die1 + die2}");
            Console.WriteLine();
        }
    }
}
