﻿float grade = float.Parse(Console.ReadLine());
PrintGrade(grade);
//"Fail"
//"Poor"
//"Good"
//"Very good"
//"Excellent"
void PrintGrade(float grade)
{
    if (grade >= 2.00 && grade <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if (grade >= 3.00 && grade <= 3.49)
    {
        Console.WriteLine("Poor");
    }
    else if (grade >= 3.50 && grade <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (grade >= 4.50 && grade <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else if (grade >= 5.50 && grade <= 6.00)
    {
        Console.WriteLine("Excellent");
    }
}