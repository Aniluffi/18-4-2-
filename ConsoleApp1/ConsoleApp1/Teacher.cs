using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher:Persone
    {
        int ExpYear { get; set; }
        string Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя экземпляра</param>
        /// <param name="surname">Фамилия экземпляра</param>
        /// <param name="bDay">День рождение экземпляра</param>
        /// <param name="faculty">Факультет экземпляра</param>
        /// <param name="expYear">Стаж экземпляра</param>
        /// <param name="position">Должность экземпляра<param>
        public Teacher(string name, string surname, DateTime bDay, string faculty,int expYear,string position) : base(name, surname, bDay, faculty)
        {
            ExpYear = expYear;
            Position = position;
        }

        /// <summary>
        /// Метод который позволяет ввести информацию о нашем экземпляре
        /// </summary>
        /// <returns>Возращает созданый экземпляр класса</returns>
        public static Teacher InputInfo()
        {
            Console.Write("Name - ");
            string name = Console.ReadLine();

            Console.Write("Surname - ");
            string surname = Console.ReadLine();

            Console.Write("Дата рождения - ");
            DateTime bDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Факультет - ");
            string faculty = Console.ReadLine();

            Console.Write("Стаж - ");
            int expYear = Int32.Parse(Console.ReadLine());

            Console.Write("Должность - ");
            string position = Console.ReadLine();

            Console.WriteLine();

            return new Teacher(name, surname, bDay, faculty,expYear,position);
        }

        /// <summary>
        /// Метод который возращает информацию о экземпляре
        /// </summary>
        /// <returns>Информация</returns>
        public override string Info()
        {
            return $"Имя - {Name} \nФамилия - {Surname}\nДата Рождения - {BDay}\nФакультет - {Faculty}\nДолжность - {Position} \nСтаж - {ExpYear}\n";
        }
    }
}