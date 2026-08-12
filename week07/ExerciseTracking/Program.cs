using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(new DateTime(2026, 8, 3), 30, 5.0);
        Running running2 = new Running(new DateTime(2026, 8, 6), 60, 10.0);

        Cycling cycling1 = new Cycling(new DateTime(2026, 8, 4), 30, 20.0);
        Cycling cycling2 = new Cycling(new DateTime(2026, 8, 7), 60, 40.0);

        Swimming swimming1 = new Swimming(new DateTime(2026, 8, 5), 30, 40);
        Swimming swimming2 = new Swimming(new DateTime(2026, 8, 8), 60, 80);

        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);
        activities.Add(running2);
        activities.Add(cycling2);
        activities.Add(swimming2);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"* {activity.GetSummary()}");
        }
    }
}
