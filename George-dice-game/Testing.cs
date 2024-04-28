using System;
using System.Diagnostics;
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
        Die die = new Die();
        int roll = die.Roll();

        // Assert that the die roll is within valid range
        Debug.Assert(roll >= 1 && roll <= 6, "Die roll is not within valid range.");
    }

    private void TestSevensOutGame()
    {
        Game sevensOut = new SevensOut();
        sevensOut.Play();
    }

    private void TestThreeOrMoreGame()
    {
        Game threeOrMore = new ThreeOrMore();
        threeOrMore.Play();
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

            // Run tests and capture any assertion failures
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                writer.WriteLine($"Exception occurred during testing: {ex.Message}");
            }
        }

        Console.WriteLine($"\nTest results have been logged to '{logFilePath}'.");
    }
}
