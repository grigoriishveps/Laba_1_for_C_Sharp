using System;

namespace Laba_1
{
    
    class Program
    {
        public static void test_list()
        {
            List<string> list = new List<string>();
            string asd = null;
            list.push_end("0");
            list.push_end("1");
            list.push_end("2");
            list.push_end("3");
          
            list.push_end("4");
            list.push_end("5");
            list.push_end("6");
            list.show();
            Console.Write("res = "+ list.get_elem(3));
            list.reverse();
            list.show(); 
        }
        
        public static void test_tree()
        {
            BinaryTree tree = new BinaryTree();
            tree.add(4);
            tree.add(0);
            tree.add(1);
            tree.add(7);
            tree.add(5);
            tree.add(13);
            tree.add(11);
            tree.add(2);
            tree.add(6);
            tree.show(); 
            Console.WriteLine(tree.search(4));
            Console.WriteLine(tree.search(11));
            Console.WriteLine(tree.search(5));
            Console.WriteLine(tree.search(7));
            Console.WriteLine(tree.search(8));
        }
        
        static void Main(string[] args)
        {
            // test_list();
            // test_tree();
            int[] numbers = {3, 5, 1, 4, 7, 2, 6};
            InsertSort.insert_sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
        }
    }
}