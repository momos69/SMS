using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.List
{
    internal class DisplayStudentData
    {
       public static void displayallstudentdata(List<Studenttype> students)
        {
            //using list

            if (students.Count > 0)
            {
                foreach (Studenttype particularstudent in students)
                {
                    Console.WriteLine($" name:{particularstudent.Name} ");
                    Console.WriteLine($"id:{particularstudent.Id}");
                    Console.WriteLine($"grade:{particularstudent.Grade}\n");

                }
            }
            else
            {
                Console.WriteLine("no student data entered");
            }
        }
    }
}
