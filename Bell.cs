using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Bell
    {
        public event Action ClockingBell;
        public void PowerOn()
        {
            bool again = false;
            string input = "";
            do
            {
                again = false;
                Console.WriteLine("Хотите включить звонок?\n" +
                                  "да/нет\n");

                input = Console.ReadLine();
                switch (input)
                {
                    case "да":
                        Console.WriteLine("ЗВОНОК!!!!!!\n");
                        ClockingBell?.Invoke();
                        break;
                    case "нет":
                        //выходим из цикла
                        //again = false; в начале цикла есть уже
                        break;
                    default:
                        Console.WriteLine("Значение не распознано, введите вариант ответа числом.\n");
                        again = true;
                        break;
                }
            } while (again);
        }


    }
}
