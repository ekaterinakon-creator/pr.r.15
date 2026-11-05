//**************************************************************************
//* Практическая работа #15                                                *
//* Выполнил: Кондратюк Е.С., группа 2-ИСП                                  *
//* Задание: Организация и использование функций                           *
//**************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace pr.r._15
{
    internal class Program
    {
           static bool WriteFile(string path)

        {
            try
            {
                Console.WriteLine("Введите количество чисел: ");
                uint count = Convert.ToUInt32(Console.ReadLine());
                FileStream F1 = new FileStream(path, FileMode.Create);
                StreamWriter writer = new StreamWriter(F1);
                Random rnd = new Random();
                for (int i = 0; i< count;i++)
                {
                    double number = 
                }
                return WriteFile(path);
            }
            catch (HandleError ex)
           
        }
        String ReadFile ()

            String Process ()

            static  HandleError ()


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Практическая работа 15";
            Console.Clear();
        }
    }
}
