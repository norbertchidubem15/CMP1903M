using System;
using System.Collections.Generic;

public class Statistics
{
    private Dictionary<string, int> gameStatistics;

    public Statistics()
    {
        gameStatistics = new Dictionary<string, int>();
    }

    public void AddGame(string gameName)
    {
        if (!gameStatistics.ContainsKey(gameName))
        {
            gameStatistics.Add(gameName, 0);
        }
    }

    public void IncrementPlays(string gameName)
    {
        if (gameStatistics.ContainsKey(gameName))
        {
            gameStatistics[gameName]++;
        }
    }

    public void DisplayStatistics()
    {
        Console.WriteLine("Game Statistics:");
        foreach (var kvp in gameStatistics)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} plays");
        }
    }
}