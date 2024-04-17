using System;

public class ThreeOrMore : Game
{
    public ThreeOrMore()
    {
        dice = new Die[5];
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = new Die();
        }
    }

    public override void Play()
    {
        Console.WriteLine("Three or More Game");
        int total = 0;
        int rolls = 0;
        do
        {
            int[] rollsArray = RollDice();
            Array.Sort(rollsArray);
            int score = CalculateScore(rollsArray);
            total += score;
            rolls++;
            Console.WriteLine($"Rolls: {rolls}, Score: {score}, Total: {total}");
        } while (total < 20);
        Console.WriteLine($"Total score reached 20 in {rolls} rolls.");
    }

    private int[] RollDice()
    {
        int[] rolls = new int[dice.Length];
        for (int i = 0; i < dice.Length; i++)
        {
            rolls[i] = dice[i].Roll();
        }
        return rolls;
    }

    private int CalculateScore(int[] rolls)
    {
        int score = 0;
        if (rolls[0] == rolls[dice.Length - 1])
        {
            score = 12;
        }
        else if (rolls[0] == rolls[dice.Length - 2] || rolls[1] == rolls[dice.Length - 1])
        {
            score = 6;
        }
        else if (rolls[0] == rolls[dice.Length - 3] || rolls[1] == rolls[dice.Length - 2] || rolls[2] == rolls[dice.Length - 1])
        {
            score = 3;
        }
        return score;
    }
}