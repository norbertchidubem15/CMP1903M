using System;
using System.IO;

public class Testing
{
    public void Test()
    {
        TestDieRoll();
        TestSevensOutGame();
        TestThreeOrMoreGame();
    }

    private void TestDieRoll()
    {
        Console.WriteLine("Testing Die Roll:");
        Die die = new Die();
        int roll = die.Roll();
        Console.WriteLine($"Die rolled: {roll}");
        if (roll >= 1 && roll <= 6)
        {
            Console.WriteLine("Die roll test passed.");
        }
        else
        {
            Console.WriteLine("Die roll test failed.");
        }
    }

    private void TestSevensOutGame()
    {
        Console.WriteLine("\nTesting Sevens Out Game:");
        Game sevensOut = new SevensOut();
        sevensOut.Play();
        Console.WriteLine("Sevens Out Game test completed.");
    }

    private void TestThreeOrMoreGame()
    {
        Console.WriteLine("\nTesting Three or More Game:");
        Game threeOrMore = new ThreeOrMore();
        threeOrMore.Play();
        Console.WriteLine("Three or More Game test completed.");
    }

    public void LogTestResults()
    {
        string logFilePath = "test_log.txt";
        using (StreamWriter writer = new StreamWriter(logFilePath))
        {
            writer.WriteLine("Test Results:");
            writer.WriteLine("----------------------");
            writer.WriteLine($"Test Date: {DateTime.Now}");
            writer.WriteLine();

            // Capture console output without redirecting the output stream
            StringWriter consoleWriter = new StringWriter();
            Console.SetOut(consoleWriter);

            // Run tests
            Test();

            // Write test output to log file
            string testOutput = consoleWriter.ToString();
            writer.WriteLine(testOutput);
        }

        Console.WriteLine($"\nTest results have been logged to '{logFilePath}'.");
    }
}