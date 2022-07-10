using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    interface ITeacher
    {
        string TeacherOf { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        bool IsMale { get; set; }


        void SetNameAndSurname();
        void MakeReviewWorkToAllStudents();
        void TakeHomeWorkForStudents();
        void TakeFreedomToAllStudents();
    }
}
