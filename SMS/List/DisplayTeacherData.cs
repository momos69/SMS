using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.List
{
    internal class DisplayTeacherData
    {
       public static void DisplayAllTeacherData(List<Teachertype> teacherlist)
        {
            if (teacherlist.Count > 0)
            {
                foreach (Teachertype particularteacher in teacherlist)
                {
                    Console.WriteLine($"Name:{particularteacher.Name}");
                    Console.WriteLine($"ID:{particularteacher.Id}");
                 
                }
            }
            else
            {
                Console.WriteLine("No Teacher Data Entered");
            }
        }
    }
}
