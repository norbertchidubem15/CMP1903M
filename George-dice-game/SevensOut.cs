using System;

public class SevensOut : Game
{
    public SevensOut()
    {
        dice = new Die[2];
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = new Die();
        }
    }

    public override void Play()
    {
        Console.WriteLine("Sevens Out Game");
        int total = 0;
        do
        {
            int roll = RollDice();
            total += roll;
            Console.WriteLine($"Rolled: {roll}, Total: {total}");
            if (roll == 7)
            {
                Console.WriteLine("You rolled a 7. Game over!");
                break;
            }
        } while (total < 7);
    }

    private int RollDice()
    {
        int roll1 = dice[0].Roll();
        int roll2 = dice[1].Roll();
        return roll1 + roll2;
    }
}