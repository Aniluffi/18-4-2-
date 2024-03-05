using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Persone
    {
       
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected DateTime BDay { get; set; }
        protected string Faculty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя экземпляра</param>
        /// <param name="surname">Фамилия экземпляра</param>
        /// <param name="bDay">День рождение экземпляра</param>
        /// <param name="faculty">Факультет экземпляра</param>
        protected Persone(string name, string surname, DateTime bDay, string faculty)
        {
            Name = name;
            Surname = surname;
            BDay = bDay;
            Faculty = faculty;
        }

        /// <summary>
        /// МЕтод для получения возраста персоны
        /// </summary>
        /// <returns>Возращаем возраст</returns>
        public int GetAge()
        {
            return DateTime.Now.Year - BDay.Year;
        }


        /// <summary>
        /// Метод который возращает информацию о экземпляре
        /// </summary>
        /// <returns>Информация</returns>
        public abstract string Info();
    }
}
