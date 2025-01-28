using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        /// <summary>
        /// имя
        /// </summary>
        public string name = "Viktor";
        /// <summary>
        /// фамилия
        /// </summary>       
        public string surname = "Donald";
        /// <summary>
        /// возраст
        /// </summary>
        public int age = 33;
        public void Print()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nВозраст: {age}");
        }



    }
}
