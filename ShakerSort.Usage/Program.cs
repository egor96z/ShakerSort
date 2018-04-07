using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSort.Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            ShakerSorter sorter = new ShakerSorter();
            Console.Write("Введите число элементов массива: ");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Отсортированный массив:");
            sorter.Sort(array);
            for (int i = 0; i < count; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
