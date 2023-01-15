using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022; 

        Job job2 = new Job();
        job2._jobTitle = "Burger Flipper";
        job2._company = "Wendy's";
        job2._startYear = 2011;
        job2._endYear = 2019; 

        Job job3 = new Job();
        job3._jobTitle = "Gamer";
        job3._company = "Mom's Basement";
        job3._startYear = 1998;
        job3._endYear = 2011; 

        Resume myResume = new Resume();
        myResume._name = "Jason Geppelt";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        myResume._jobList.Add(job3);
        myResume.DisplayResume();
    }
}