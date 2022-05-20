using SchoolProgram.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            var teachers = new List<ITeacher>();
            //GymTeacher = new Teacher();
            teachers.Add(new AlgebraTeacher());
            teachers.Add(new BiologyTeacher());

            new Bell().PowerOn();

            Console.ReadLine();
        }

        
    }
}
