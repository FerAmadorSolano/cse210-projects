using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2022;
        //Console.WriteLine(job1._company);
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //Console.WriteLine(job2._company);
        //job2.Display();

        Job job3 = new Job();
        job3._company = "Google";
        job3._jobTitle = "Developer";
        job3._startYear = 2024;
        job3._endYear = 2026;
        //Console.WriteLine(job3._company);
        //job3.Display();

        Resume myResume = new Resume();
        myResume._name = "Fernanda Amador";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }

}