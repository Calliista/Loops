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
            int entry, die1, die2, tries = 0, pins = 0, count =0, number, randNum1, randNum2, randNum3, randNum4, temp, guess;
            bool done = false;
            string food;

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
                Console.WriteLine($"{die1} - {die2}");
               
            }
            Console.WriteLine("You got doubles!");

            //7.2
            Console.WriteLine("Type in a message, and I'll desplay it 5 times.");
            Console.Write("Message: ");
            string message = Console.ReadLine();
            for (int i = 1; i <= 5; i = i + 1)
            {
                Console.WriteLine(i + ": " + message);
            }
            Console.WriteLine();

            Console.WriteLine("What's your favorite food?");
            Console.Write("Favorite food: ");
            food = Console.ReadLine();
            for (int i = 1; i <= 5; i = i + 1)
            {
                Console.WriteLine(i + ": " + food +" is delicious");
            }
            Console.WriteLine();

            Console.WriteLine("What do you want me to count to?");
            int.TryParse(Console.ReadLine(), out number);
            for (int i = 0; i <= number; i = i + 1)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("");

            //while (count < 5);
            //{
            //    Console.WriteLine((count + 1));
            //}

            //7.1
            //Assignment 1
            randNum1 = generator.Next(10);
            Console.WriteLine(randNum1.ToString());
            randNum2 = generator.Next(10);
            Console.WriteLine(randNum2.ToString());
            randNum3 = generator.Next(10);
            Console.WriteLine(randNum3.ToString());
            randNum4 = generator.Next(10);
            Console.WriteLine(randNum4.ToString());
            Console.WriteLine();
            Console.WriteLine("Average:");
            Console.WriteLine((randNum1 + randNum2 + randNum3 + randNum4) / 4);
            Console.WriteLine();

            //Assignment 2
            temp = generator.Next(100);
            Console.WriteLine("Guess the tempurature: (1-100)");
            int.TryParse(Console.ReadLine(), out guess);
            while (guess != temp)
            {
                if (guess > temp)
                {
                    Console.WriteLine("Too high");
                    Console.Write("Try again:");
                    int.TryParse(Console.ReadLine(), out guess);
                    Console.WriteLine();
                }
                if (guess < temp)
                {
                    Console.WriteLine("Too Low");
                    Console.Write("Try again:");
                    int.TryParse(Console.ReadLine(), out guess);
                    Console.WriteLine();
                }

            }
            Console.WriteLine("You got it right!");

            //7.2
            //Assignmrnt 1
            for (int i = 0; i <= 9; i = i + 1)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("Blastoff!");
            Console.WriteLine();

            //Assignment 2
            for (int i = -11; i <= 9; i = i + 2)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine();
            for (int y = -11; y <= 9; y = y + 2)
            {
                Console.WriteLine(y + 1);
            }
            Console.WriteLine();

            //Assignment 3
            Console.Write("name: ");
            message = Console.ReadLine();
            if (message == "Aldworth")
            {
                for (int i = 1; i <= 5; i = i + 1)
                {
                    Console.WriteLine(i + ": " + message);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= 10; i = i + 1)
                {
                    Console.WriteLine(i + ": " + message);
                }
                Console.WriteLine();
            }
        }
    }
}
