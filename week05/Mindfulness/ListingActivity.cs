using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        _count = 0;

        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are things that made you smile today?",
            "Who has had a positive influence on your life?",
            "What are talents or skills you are grateful to have?",
            "What blessings have you received this week?",
            "What are places where you feel peaceful?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> answers = GetListFromUser();

        _count = answers.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        ShowSpinner(3);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("🦋 ");
            answers.Add(Console.ReadLine());
        }

        return answers;
    }
}