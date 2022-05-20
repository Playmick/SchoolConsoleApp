using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    abstract class BaseTeacher : ITeacher
    {
        private string name;
        private Action EndOfLesson;
        
        //конструктор
        public BaseTeacher(string nameOfTeacher)
        {
            name = nameOfTeacher;

            EndOfLesson = MakeReviewWorkToAllStudents;
            EndOfLesson += TakeHomeWorkForStudents;
            EndOfLesson += TakeFreedomToAllStudents;
        }

        public void MakeReviewWorkToAllStudents()
        {
            Console.WriteLine("Выставили оценки за работу на уроке.");
        }

        public void TakeHomeWorkForStudents()
        {
            Console.WriteLine("Дали домашку ученикам.");
        }

        public void TakeFreedomToAllStudents()
        {
            Console.WriteLine("Отпустили учеников с урока.");
        }
    }
}
