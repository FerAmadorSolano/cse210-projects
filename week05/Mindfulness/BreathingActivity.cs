using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int timePassed = 0;

        while (timePassed < GetDuration())
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountDown(6);
            timePassed += 6;

            Console.Clear();
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            timePassed += 6;

            if (timePassed >= GetDuration())
            {
                break;
            }

        }

        DisplayEndingMessage();
    }
}
