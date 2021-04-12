using Laba_1;
using NUnit.Framework;

namespace TestProject1
{
    public class TestSort
    {
        private int[] result_array;
        
        [SetUp]
        public void Setup()
        {
            result_array = new int[]{1, 2, 3, 4, 5, 6, 7};
        }
        
        [Test]
        public void test_sorted()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7};
            InsertSort.insert_sort(array);
            CollectionAssert.AreEqual( result_array, array);
        }
        
        [Test]
        public void test_sorted_reverse()
        {
            int[] array = {7, 6, 5, 4, 3, 2, 1};
            InsertSort.insert_sort(array);
            CollectionAssert.AreEqual( result_array, array);
        }
        
        
        [Test]
        public void test_random()
        {
            int[] array = {3, 5, 1, 4, 7, 2, 6};
            InsertSort.insert_sort(array);
            CollectionAssert.AreEqual( result_array, array);
        }
        
        [Test]
        public void test_sorted_with_change_firstlast()
        {
            int[] array = {7, 2, 3, 4, 5, 6, 1};
            InsertSort.insert_sort(array);
            CollectionAssert.AreEqual( result_array, array);
        }
        
        [Test]
        public void test_sorted_with_change_couple()
        {
            int[] array = {1, 2, 3, 5, 4, 6, 7};
            InsertSort.insert_sort(array);
            CollectionAssert.AreEqual( result_array, array);
        }
        
       
    }
}