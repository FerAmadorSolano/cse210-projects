using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you overcame a fear.",
            "Think of a time when you helped someone without expecting anything in return.",
            "Think of a time when you accomplished an important goal.",
            "Think of a time when you learned something from a difficult experience.",
            "Think of a time when you made someone feel appreciated.",
            "Think of a time when you stepped outside your comfort zone.",
            "Think of a time when you encouraged someone who was struggling.",
            "Think of a time when you remained calm during a stressful situation.",
            "Think of a time when you learned a valuable lesson from a mistake."
        };

        _questions = new List<string>()
        {
            "Why was this experience important to you?",
            "What did you learn from this experience?",
            "How did this experience help you grow?",
            "What strengths did you use?",
            "How did you feel afterward?",
            "What would you do differently if it happened again?",
            "How has this experience influenced your life?",
            "Who else benefited from your actions?",
            "What are you most proud of about this experience?",
            "What was the most rewarding part of this experience?",
            "What surprised you the most?",
            "Would you handle the situation differently today? Why?",
            "What motivated you to keep going?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now consider the following questions:");

        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        int i = _random.Next(_questions.Count);
        return _questions[i];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.Write($"> {GetRandomQuestion()} ");
    }
}