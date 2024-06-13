using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.List
{
    internal class ListAddStudentData
    {
        public static void EnterStudentData(List<Studenttype> students, int i)
        {
           
            Studenttype student = new Studenttype();
 

            Console.WriteLine($"{i}: Student Details");

            Console.WriteLine("Name:");
            student.Name = Console.ReadLine();

            
            Console.WriteLine("ID:");
            student.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade:");
            Enums.Grade grade;
            Enums.Grade.TryParse(Console.ReadLine(), out grade);
            student.Grade = grade;

            
            students.Add(student);

            Console.WriteLine("Entry Successful");
        }
    }
}
