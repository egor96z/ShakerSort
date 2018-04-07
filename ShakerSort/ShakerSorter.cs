using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSort
{
    public class ShakerSorter
    {
        public void Sort(int[] myint)
        {
            if (myint == null)
                throw new ArgumentNullException();
            int left = 0, // слева
                right = myint.Length - 1; // справа

            while (left <= right)
            {
                // идём слева направо
                for (int i = left; i < right; i++)
                    if (myint[i] > myint[i + 1]) // если левый больше правого -- меняем их
                        Swap(myint, i, i + 1);
                right--; // у нас теперь спарва самый большой элемент и его больше не надо 
                // сортировать 

                for (int i = right; i > left; i--)
                    if (myint[i - 1] > myint[i]) // теперь идём справа налево
                        Swap(myint, i - 1, i); // и меняем так, чтобы меньший элемент оказался слева
                left++; // он теперь слева и его больше не рассматриваем
            }
        }

        // меняет местами i и j элементы массива
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
