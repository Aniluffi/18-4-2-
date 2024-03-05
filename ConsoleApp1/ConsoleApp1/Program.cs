using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //лист ,где хранятся создаваемые персоны
            List<Persone> list = new List<Persone>();

            ///Создание и добавление экземпляров в лист
            bool flag = true;//флаг ,который останавливает бесконечный массив

            while (flag)
            {
                Console.WriteLine("Введите название");
                string s = Console.ReadLine();//переменная которая сохраняет значение для создания 
                //экземпляра класса,который нам необходим

                switch (s)
                {
                    case "А": list.Add(Enrollee.InputInfo()); break;
                    case "С": list.Add(Student.InputInfo()); break;
                    case "У": list.Add(Teacher.InputInfo()); break;

                    default: flag = false; break;
                }
            }

            //вывод данных с листа
            foreach (var z in list)
            {
                Console.WriteLine(z.Info());
            }
            //Вывод людей ,чей возраст попадпет в заданный диапозон
            Console.Write("Введите нижнюю гранмцу возраста - ");
            int downAge = Int32.Parse(Console.ReadLine());//нижняя граница диапозона

            Console.Write("Введите верхнюю гранмцу возраста - ");
            int upAge = Int32.Parse(Console.ReadLine());//верхняя граница диапозона

            Console.WriteLine();

            Console.WriteLine("Персоны,чей возраст попадает в заданый диапозон");
            //вывод персон чей возраст попадает в диапозон
            foreach (var z in list)
            {
                if (downAge < z.GetAge() & z.GetAge() < upAge)//все что между нижней и верхней границей является возрастом в нужном нам диапозоне
                {
                    Console.WriteLine(z.Info());
                }
            }
        }
    }
}