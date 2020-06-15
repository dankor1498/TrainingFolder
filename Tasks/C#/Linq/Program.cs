using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static School[] WriteSchool(string textName)
        {
            List<School> schools = new List<School>();
            try
            {
                using (StreamReader sr = new StreamReader(textName))
                {
                    while (sr.Peek() > -1)
                    {
                        string line = sr.ReadLine();

                        string[] split = line.Split(' ');
                        School school = new School(split[0], 
                            Convert.ToInt32(split[1]), Convert.ToInt32(split[2]));
                        schools.Add(school);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return schools.ToArray<School>();
        }


        static void Main(string[] args)
        {
            School[] schools = WriteSchool("text.txt");

            var schoolsGrouped = from s in schools
                                 orderby s.Number
                                 group s by s.Number;

            foreach (var sg in schoolsGrouped)
            {
                Console.WriteLine(
                $"Number: {sg.Key}\t{sg.Count()} names");
                foreach (var n in sg)
                {
                    Console.WriteLine($"\t{n.Name}");
                    //break; //для вывода только первой фамилии в списке
                }
            }

            var schoolsList = from s in schools
                              select new { s.Name, s.Year, s.Number };

            foreach (var s in schoolsList)
            {
                Console.WriteLine($"Name - {s.Name, -8} " +
                    $"Year - {s.Year} Number school - {s.Number, 2}");
            }
        }
    }
}
