using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QS.Usage
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 9, 0, 2 };
            //string[] arr = { "c", "5", "2.6", "-" };
            string[] arr = { "0", "5", "2.6", "3" };
            double[] nums = SortStrings(arr, 0, arr.Length - 1);
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadKey();
        }

        public static double[] SortStrings(string[] arr, long left, long right)
        {
            double[] nums = null;

            try
            {
                nums = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (double.TryParse(arr[i], out nums[i]))
                        nums[i] = double.Parse(arr[i]);
                    else
                        throw new QuickSortingException("Not all values could be converted to numbers");
                }

                QuickSorting.Sort(nums, 0, nums.Length - 1);
            }
            catch (QuickSortingException e)
            {
                Console.WriteLine(e.ToString());
            }

            return nums;
        }
    }
}
