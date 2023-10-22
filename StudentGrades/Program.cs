// Student Grading System
// Made By :- Eslam Mohamed  - on 22/10/2023
// Version :- 1.0 D
using System;
namespace Eslam;
class Program
{
    static void Main()
    {
        // Variables Decleration
        string studentName;
        int degree = 0;
        char grade = 'c';
        int numOfCourse;
        int counter = 0;
        
        //Reading Variables from user
        Console.WriteLine("Enter Student Name");
        studentName = Console.ReadLine();
        Console.WriteLine("Welcome " + studentName);
        Console.WriteLine("Enter Number of Courses");
        numOfCourse = Convert.ToInt32(Console.ReadLine());


        // Loop for playing calculator by number of courses
        while(counter < numOfCourse)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter Student degree from range 0-100");
            degree = Convert.ToInt32(Console.ReadLine());

            if (degree >= 90 & degree <= 100)
            {
                grade = 'A';
            }
            else if (degree >= 80 & degree < 90)
            {
                grade = 'B';
            }
            else if (degree >= 70 & degree < 80)
            {
                grade = 'C';
            }
            else if (degree >= 60 & degree < 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("Your Grade for course no: " + (counter+1) + " is\t" + grade);

            counter++;
        }


    }
}