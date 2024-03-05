using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Student:Persone
    { 
    int Kurs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя экземпляра</param>
        /// <param name="surname">Фамилия экземпляра</param>
        /// <param name="bDay">День рождение экземпляра</param>
        /// <param name="faculty">Факультет экземпляра</param>
        /// <param name="kurs">Курс экземпляра</param>
        public Student(string name, string surname, DateTime bDay, string faculty, int kurs) : base(name, surname, bDay, faculty)
    {
        Kurs = kurs;
    }

        /// <summary>
        /// Метод который позволяет ввести информацию о нашем экземпляре
        /// </summary>
        /// <returns>Возращает созданый экземпляр класса</returns>
        public static Student InputInfo()
    {
        Console.Write("Name - ");
        string name = Console.ReadLine();

        Console.Write("Surname - ");
        string surname = Console.ReadLine();

        Console.Write("Дата рождения - ");
        DateTime bDay = DateTime.Parse(Console.ReadLine());

        Console.Write("Факультет - ");
        string faculty = Console.ReadLine();

        Console.Write("Курс - ");
        int kurs = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            return new Student(name, surname, bDay, faculty, kurs);
    }

        /// <summary>
        /// Метод который возращает информацию о экземпляре
        /// </summary>
        /// <returns>Информация</returns>
        public override string Info()
    {
        return $"Имя - {Name}\nФамилия - {Surname}\nДата Рождения - {BDay}\nФакультет - {Faculty}\nКурс - {Kurs}\n";
    }
}
    }

