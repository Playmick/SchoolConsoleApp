using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Bell
    {
        public void PowerOn()
        {
            bool again = true;
            string input = "";
            while (again)
            {
                again = false;
                Console.WriteLine("Хотите включить звонок?\n" +
                                  "да/нет\n");

                input = Console.ReadLine();
                switch(input)
                {
                    case "да":
                        Console.WriteLine("ЗВОНОК!!!!!!\n");
                        break;
                    case "нет":
                        //выходим из цикла
                        break;
                    default:
                        Console.WriteLine("Значение не распознано, введите вариант ответа числом.\n");
                        again = true;
                        break;
                }
            }
        }


    }
}
