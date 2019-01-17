using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLesson
{
    class Program
    {
        static void Main(string[] args)
        {


            int minimumRange;
            int maximumRange;
            Console.WriteLine("Задайте диапазон индексации: ");
            Console.WriteLine("От: ");
            while(!int.TryParse(Console.ReadLine(), out minimumRange))
            {
                Console.WriteLine("Input error!");
            }
            Console.WriteLine("До: ");
            while (!int.TryParse(Console.ReadLine(), out maximumRange))
            {
                Console.WriteLine("Input error!");
            }
            int size = 0;
            for (int i = minimumRange; i <= maximumRange; i++)
            {
                size++;
            }
            var rangeOfArray = new RangeOfArray(size);


            rangeOfArray.Minimum = minimumRange;
            rangeOfArray.Maximum = maximumRange;
            if (maximumRange < minimumRange)
            {
                for (int i = minimumRange; i <= maximumRange; i--)
                {
                    rangeOfArray[i] = i;
                }

                for (int i = minimumRange; i <= maximumRange; i--)
                {
                    Console.WriteLine(rangeOfArray[i]);
                }
            }
            else
            {
                for (int i = minimumRange; i <= maximumRange; i++)
                {
                    rangeOfArray[i] = i;
                }

                for (int i = minimumRange; i <= maximumRange; i++)
                {
                    Console.WriteLine(rangeOfArray[i]);
                }
            }
            
            Console.Read();
        }
    }
}
