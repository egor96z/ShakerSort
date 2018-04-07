using System;
using ShakerSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShakerSort.Tests
{
    [TestClass]
    public class ShakerSortTests
    {
        private ShakerSorter sorter = new ShakerSorter();

        [TestMethod]
        public void Sort_SimpleArray()
        {
            int[] array = new int[4] {5, 1, 6, 2};
            sorter.Sort(array);
            int[] expected = new int[4] {1, 2, 5, 6};
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void Sort_SingleElementArray()
        {
            int[] array = new int[1] { 0 };
            sorter.Sort(array);
            int[] expected = new int[1] { 0 };
            CollectionAssert.AreEqual(expected, array);
        }
           
        [TestMethod]
        public void Sort_EmptyArray()
        {
            int[] array = new int[0];
            sorter.Sort(array);
            int[] expected = new int[0];
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
