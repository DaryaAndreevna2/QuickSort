using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QS.Usage;

namespace QS.Tests
{
    [TestClass]
    public class QSTest
    {
        [TestMethod]
        public void QuickSorting_ValidValues()
        {
            string[] arr = { "0", "5", "2.6", "3" };
            double[] expected = { 0, 2.6, 3, 5 };
            double[] actual = Program.SortStrings(arr, 0, arr.Length - 1);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(QuickSortingException))]
        public void QuickSorting_InvalidValues()
        {
            string[] arr = { "c", "5", "2.6", "-" };
            Program.SortStrings(arr, 0, arr.Length - 1);
        }
    }
}
