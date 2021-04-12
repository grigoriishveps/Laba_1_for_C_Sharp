using Laba_1;
using NUnit.Framework;

namespace TestProject1
{
    public class TestList
    {
        [TestCase(0)]
        [TestCase(3)]
        [TestCase(6)]
        public void test_get(int index)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            Assert.AreEqual( $"{index}", list.get_elem(index));
        }
        
        [TestCase(0, 0)]
        [TestCase(2, 2)]
        [TestCase(6, 6)]
        public void test_start_reverse(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_start("6");
            list.push_start("5");
            list.push_start("4");
            list.push_start("3");
            list.push_start("2");
            list.push_start("1");
            list.push_start("0");
            
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        public void test_pushend(int index)
        {
            List<string> list = new List<string>();
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_start("0");
            list.push_end("6");
            Assert.AreEqual( $"{index}", list.get_elem(index));
        }
        
        [TestCase(0, 8)]
        [TestCase(1, 0)]
        public void test_insert_start(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.insert_elem("8", 0);
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(4, 8)]
        [TestCase(5, 4)]
        [TestCase(7, 6)]
        public void test_insert_middle(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.insert_elem("8", 4);
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        
        [TestCase(7, 8)]
        [TestCase(6, 6)]
        public void test_insert_end(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.insert_elem("8", 7);
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void test_delete_start(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.delete_start();
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 6)]
        public void test_delete_middle(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.delete_elem(4);
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
        
        [TestCase(5, 6)]
        [TestCase(4, 4)]
        public void test_delete_end(int index, int answer)
        {
            List<string> list = new List<string>();
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
            list.push_end("4");
            list.push_end("5");
            list.delete_end();
            list.push_end("6");
            Assert.AreEqual( $"{answer}", list.get_elem(index));
        }
    }
}