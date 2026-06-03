using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newMath = new MathAssignment("Santiago Matias","Fractions","2.4","9-15");
        Console.WriteLine("Math Assignment:");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomeworkList());

        WritingAssignment newWriting = new WritingAssignment("Santiago Matias","World History","The causes of WWII");
        Console.WriteLine("Writing Assignment:");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetHomeworkList());


    }
}