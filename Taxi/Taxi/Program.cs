using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        enum Tariff { OneRide = 1, RegularCustomer = 2, Subscription = 3 };
        int[] id;
        int[] km;
        public int Profit { get; private set; }
        public Taxi(int[] cInf, int[] rInf)
        {
            
        }

        int CalculateOneRide(int[] k) => k.Sum() * 8;
        
        int CalculateRegularCustomer(int[] k)
        {
            int sale = 0;
            int sum = 0;
            for(int i = 0; i < k.Length; i++)
            {
                sum += (k[i] * 6 + sale) < 0 ? 0 : (k[i] * 6 + sale);
                sale = (k[i] * 6 + sale) / 2 < 0 ? 0 : (k[i] * 6 + sale) / 2;
            }
            return sum;
        }

        int CalculateSubscription(int[] k)
        {
            if(k.Sum() < 100)
            {
                return k.Sum() * 6;
            }
            return 600 + (k.Sum() - 100 * 4);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 11, 4, 3, 7, 12 };

            var indexes = list.Select((item, index) => new { Item = item, Index = index })
                     .Where(n => n.Index % 2 == 0)
                     .Select(n => n.Item);


            Console.WriteLine("Even numbers:");
            foreach (var index in indexes)
            {
                Console.WriteLine(index);
            }
        }
    }
}
