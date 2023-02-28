using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startDate = "2/12";
        job1._endDate = "5/15";
        
        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._companyName = "Apple";
        job2._startDate = "6/15";
        job2._endDate = "present";

        Resume resume = new Resume();
        resume._member = "FirstName LastName";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}