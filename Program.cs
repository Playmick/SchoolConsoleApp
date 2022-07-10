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
        public static Bell bell = new Bell();
        static void Main(string[] args)
        {
            var teachers = new List<ITeacher>();
            //GymTeacher = new Teacher();
            //сначала нужно прочесть их из файла
            //потом предложить устроить новых учителей

            teachers.Add(new AlgebraTeacher());
            //teachers.Add(new BiologyTeacher());

            bell.PowerOn();

            Console.ReadLine();
        }

        
    }
}
