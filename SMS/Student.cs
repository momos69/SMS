using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SMS.Enums;

namespace SMS
{
    public class Studenttype
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Class Class { get; set; }
        public double Percentage { get; set; }
        public Grade Grade { get; set; }
        

        //    public Studenttype(string name, int id, Class classLevel, double percentage, Grade grade)
        //{
        //    Name = name;
        //    Id = id;
        //    Class = classLevel;
        //    Percentage = percentage;
        //    Grade = grade;
        //}
    }
}
