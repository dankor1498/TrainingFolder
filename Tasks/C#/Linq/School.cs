using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class School
    {
        private string name;
        private int year;
        private int number;

        public School()
        {
            this.name = default(string);
            this.year = default(int);
            this.number = default(int);
        }

        public School(string name, int year, int number)
        {
            this.name = name;
            this.year = year;
            this.number = number;
        }

        public string Name { get => name; }
        public int Year { get => year; }
        public int Number { get => number; }
    }
       
}
