using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Address
    {
        /// <summary>
        /// индекс
        /// </summary>
        public int index = 3056;
        /// <summary>
        /// страна
        /// </summary>       
        public string country = "Makedonia";
        /// <summary>
        /// город
        /// </summary>
        public string city = "Parcho";
        /// <summary>
        /// улица
        /// </summary>
        public string street = "Vina";
        /// <summary>
        /// дом
        /// </summary>
        public int house = 17;
        /// <summary>
        /// аппартаменты
        /// </summary>
        public int appartamet = 21;
        public void Print()
        {
            Console.WriteLine($"Индекс: {index}\nСтрана: {country}\nГород: {city}\nУлица: {street}\nДом: {house}\nАппартаменты: {appartamet}");
        }
    }
}
