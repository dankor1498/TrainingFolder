using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    class CaloriesPerGram
    {
        const double protein = 4.1;
        const double fats = 9.3;
        const double carbohydrates = 4.1;

        double proteinG;
        double fatsG;
        double carbohydratesG;

        public int ID
        {
            get;
            private set;
        }

        public CaloriesPerGram(int id, double p, double f, double c)
        {
            ID = id;
            proteinG = p;
            fatsG = f;
            carbohydratesG = c;
        }

        public double CaloryGram
        {
            get
            {
                return proteinG * protein + fatsG * fats + carbohydratesG * carbohydrates;
            }
        }
    }

    class Program
    {
        class Food
        {
            public int ID { get; set; }
            public double Grams { get; set; }

            public Food(int id, double grams)
            {
                ID = id;
                Grams = grams;
            }
        }

        static void ReadArray(string input, List<CaloriesPerGram> c, List<Food> f)
        {
            string[] inputs = input.Split();

            int i = 0;
            for( ; i < inputs.Length; i++)
            {
                if (inputs[i] == "-1")
                {
                    i++;
                    break;
                }
                c.Add(new CaloriesPerGram(int.Parse(inputs[i++]), 
                    double.Parse(inputs[i++]), 
                    double.Parse(inputs[i++]), 
                    double.Parse(inputs[i])));
            }

            for (; i < inputs.Length; i++)
            {
                if (inputs[i] == "-1")
                {
                    break;
                }
                f.Add(new Food(int.Parse(inputs[i]), double.Parse(inputs[++i])));                   
            }
        }

        static void Main(string[] args)
        {
            List<CaloriesPerGram> caloriesPerGrams = new List<CaloriesPerGram>();
            List<Food> food = new List<Food>();            
            ReadArray(Console.ReadLine(), caloriesPerGrams, food);

            double sumCalories = 0.0;

            foreach(var p in food)
            {
                for(int i = 0; i < caloriesPerGrams.Count; i++)
                {
                    if(p.ID == caloriesPerGrams[i].ID)
                    {
                        sumCalories += caloriesPerGrams[i].CaloryGram * p.Grams;
                        break;
                    }
                }
            }
            Console.Write($"{sumCalories:f2}");
        }
    }
}
