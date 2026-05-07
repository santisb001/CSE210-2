using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._company = "MRoyo";
        job2._jobTitle = "Auxiliary treasurer";
        job2._startYear = 2024;
        job2._endYear = 2030;

        Resume resume1 = new Resume();
        resume1._name = "Santiago Sburlati";
        resume1.AddJob(job1);
        resume1.AddJob(job2);
        resume1.Display();
        
    }
}