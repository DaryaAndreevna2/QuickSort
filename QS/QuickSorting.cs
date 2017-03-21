using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QS
{
    /// <summary>
    /// Реализация алгоритма быстрой сортировки
    /// В качестве входных значений метод принимает сам массив, первый и последний элементы
    /// </summary>
    public class QuickSorting
    {
        public static void Sort<T>(T[] items, long left, long right) where T : IComparable
        {
            T p = items[(right - left) / 2 + left]; // берём центральный элемент
            T temp;
            long i = left, j = right;
            while (i <= j)
            {
                // Пока элемент меньше центрального и не достигли последнего, двигаемся вправо
                while (items[i].CompareTo(p) < 0 && i <= right)
                    ++i;
                // Пока элемент из правой части больше центрального и не достигли первого, двигаемся влево
                while (items[j].CompareTo(p) > 0 && j >= left)
                    --j;
                if (i <= j)
                {
                    // Меняем элементы местами
                    temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                    ++i; --j;
                }
            }
            // Рекурсивно вызываем этот же метод для дальнейшей сортировки
            if (j > left)
                Sort(items, left, j);
            if (i < right)
                Sort(items, i, right);
        }
    }
}
