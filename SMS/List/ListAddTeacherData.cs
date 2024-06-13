using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMS.List
{
    internal class ListAddTeacherData
    {
        public static void EnterTeacherData(List<Teachertype> teachers, int j)
        {
            Teachertype teacher = new Teachertype();

            Console.WriteLine($"{j} : Teacher Details");

            try
            {
                Console.WriteLine(" Name:");
                teacher.Name = Console.ReadLine();
                Console.WriteLine("ID:");
                teacher.Id = Convert.ToInt32(Console.ReadLine());


                teachers.Add(teacher);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Invalid Value");
            }
        }
    }
}
