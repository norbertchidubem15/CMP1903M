using System;

public class Program
{
    public static void Main(string[] args)
    {
        Die[] dice = { new Die(), new Die() };
        Game sevensOut = new SevensOut();
        Game threeOrMore = new ThreeOrMore();
        Testing testing = new Testing();

        Statistics statistics = new Statistics();
        statistics.AddGame("Sevens Out");
        statistics.AddGame("Three or More");

        bool exit = false;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Play Sevens Out");
            Console.WriteLine("2. Play Three or More");
            Console.WriteLine("3. View Statistics");
            Console.WriteLine("4. Run Tests");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        sevensOut.Play();
                        statistics.IncrementPlays("Sevens Out");
                        break;
                    case 2:
                        threeOrMore.Play();
                        statistics.IncrementPlays("Three or More");
                        break;
                    case 3:
                        statistics.DisplayStatistics();
                        break;
                    case 4:
                        testing.LogTestResults();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (!exit);
    }
}