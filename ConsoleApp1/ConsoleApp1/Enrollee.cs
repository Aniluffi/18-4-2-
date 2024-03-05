using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enrollee : Persone
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя экземпляра</param>
        /// <param name="surname">Фамилия экземпляра</param>
        /// <param name="bDay">День рождение экземпляра</param>
        /// <param name="faculty">Факультет экземпляра</param>
        public Enrollee(string name, string surname, DateTime bDay, string faculty) : base(name, surname, bDay, faculty)
        {
           
        }

        /// <summary>
        /// Метод который позволяет ввести информацию о нашем экземпляре
        /// </summary>
        /// <returns>Возращает созданый экземпляр класса</returns>
        public static Enrollee InputInfo()
        {
            Console.Write("Name - ");
            string name = Console.ReadLine();

            Console.Write("Surname - ");
            string surname = Console.ReadLine();

            Console.Write("Дата рождения - ");
            DateTime bDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Факультет - ");
            string faculty = Console.ReadLine();

            Console.WriteLine();


            return new Enrollee(name, surname, bDay, faculty);
        }

        /// <summary>
        /// Метод который возращает информацию о экземпляре
        /// </summary>
        /// <returns>Информация</returns>
        public override string Info()
        {
            return $"Имя - {Name}\nФамилия - {Surname}\nДата Рождения - {BDay}\nФакультет - {Faculty}\n ";
        }
    }
}