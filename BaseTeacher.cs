using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    abstract class BaseTeacher : ITeacher
    {
        private string teacherOf;
        private string name;
        private string surname;
        private bool isMale;

        private Action EndOfLesson;

        public string TeacherOf { get => GetScience(); set => teacherOf = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public bool IsMale { get => isMale; set => isMale = value; }


        //конструктор
        public BaseTeacher()
        {
            SetNameAndSurname();
            
            EndOfLesson = MakeReviewWorkToAllStudents;
            EndOfLesson += TakeHomeWorkForStudents;
            EndOfLesson += TakeFreedomToAllStudents;

            //все учителя заканчивают урок и подписываются на событие звонка
            Program.bell.ClockingBell += EndOfLesson;

        }

        //можно было бы заюзать private protected, но он доступен только от C# 7.2, а тут 7.0
        protected virtual string GetScience() => "обычный учитель";

        public void SetNameAndSurname()
        {
            Console.WriteLine($"К вам в школу устроился новый {TeacherOf}.");
            bool again = false;
            do
            {
                again = false;
                Console.WriteLine("Введите пол (м/ж):");

                #region CheckGender
                switch (Console.ReadLine())
                {
                    case "м":
                    case "М":
                    case "муж":
                    case "Муж":
                    case "мужчина":
                    case "Мужчина":
                    case "Мужской":
                    case "мужской":
                    case "1":
                        isMale = true;
                        break;
                    case "ж":
                    case "Ж":
                    case "жен":
                    case "Жен":
                    case "женщина":
                    case "Женщина":
                    case "женский":
                    case "Женский":
                    case "2":
                        isMale = false;
                        break;
                    default:
                        Console.WriteLine("Введите пол одной буквой кириллицей.\n Например: м");
                        again = true;
                        break;
                }
                #endregion

                if(!again)
                {
                    if (isMale)
                    {
                        Console.WriteLine("Введите пожалуйста его имя:");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите пожалуйста его фамилию:");
                        surname = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Введите пожалуйста её имя:");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите пожалуйста её фамилию:");
                        surname = Console.ReadLine();
                    }
                }
            } while (again);
            
        }

        public void MakeReviewWorkToAllStudents() => Console.WriteLine("Выставил оценки за работу на уроке.");

        public void TakeHomeWorkForStudents() => Console.WriteLine("Дал домашку ученикам.");

        public void TakeFreedomToAllStudents() => Console.WriteLine("Отпустил учеников с урока.");
        
    }
}
