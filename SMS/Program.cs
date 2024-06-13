using System;
using System.Collections.Generic;
using SMS.List;
using SMS;

namespace SMS
{
    internal class Program
    {
        static List<Studenttype> students = new List<Studenttype>();
        static List<Teachertype> teachers = new List<Teachertype>();

        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Enter Student Data");
                Console.WriteLine("2. Enter Teacher Data");
                Console.WriteLine("3. Display Student Data");
                Console.WriteLine("4. Display Teacher Data");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Student Data:");
                        ListAddStudentData.EnterStudentData(students, students.Count + 1);
                        break;
                    case "2":
                        Console.WriteLine("Enter Teacher Data:");
                        ListAddTeacherData.EnterTeacherData(teachers, teachers.Count + 1);
                        break;
                    case "3":
                        Console.WriteLine("Displaying Student Data:");
                        DisplayStudentData.displayallstudentdata(students);
                        break;
                    case "4":
                        Console.WriteLine("Displaying Teacher Data:");
                        DisplayTeacherData.DisplayAllTeacherData(teachers);
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
