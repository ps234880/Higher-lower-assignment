Random random = new();
bool playGame = true;

// gameloop
while (playGame)
{
    int randomNumber = random.Next(1, 100);
    int guessedNumber = 0;

    Console.WriteLine("Enter a number between 1 and 100");

    // input loop
    while (guessedNumber != randomNumber)
    {
        try
        {
            guessedNumber = Convert.ToInt32(Console.ReadLine());

            if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Too high.");
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Too low.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Try again");
        }
    }

    Console.WriteLine("You won. Try Again? y-n");

    // try again loop
    while (guessedNumber == randomNumber)
    {
        string input = Console.ReadLine();

        if (input == "y")
        {
            guessedNumber = 0;
        }
        else if (input == "n")
        {
            guessedNumber = 0;
            playGame = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Try again");
        }
    }
}

//using System;

//namespace Higher_lower_assignment
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int randomNumber = Random();

//            Console.WriteLine(Convert.ToString(randomNumber), "test");

//            //GameLoop(randomNumber);
//        }
//        // voor kleine projecten heeft dit geen meerwaarden

//        // besproken over solo project. crud 
//        private static int Random()
//        {
//            Random random = new();
//            int randomNumber = random.Next(0, 10);
//            Console.Write("New number = ");
//            Console.WriteLine(randomNumber);
//            return randomNumber;
//        }
//        private static int Guess()
//        {
//            Console.WriteLine("Enter a number between 1 and 10");

//            while (true)
//            {
//                try
//                {
//                    int guessedNumber = Convert.ToInt32(Console.ReadLine());
//                }
//                catch
//                {
//                    Console.WriteLine("Invalid input");
//                }
//            }
//        }

//        private static void GameLoop(int guessedNumber, int randomNumber)
//        {
//            while (guessedNumber != randomNumber)
//            {
//                if (guessedNumber < randomNumber)
//                {
//                    Console.WriteLine("Too low.");

//                }
//                else if (guessedNumber > randomNumber)
//                {
//                    Console.WriteLine("Too high.");
//                }
//            }

//            Console.WriteLine("You won. Try Again? y-n");
//            string input = Console.ReadLine();

//            if (input == "y")
//            {
//                //Random();
//                //GameLoop(guessedNumber, randomNumber);
//            }
//            else if (input == "n")
//            {
//                //break;
//            }
//        }
//    }
//}