using System;
using System.Net.Sockets;

namespace Laba_1
{
    public class NodeTree
    {
        public NodeTree(int data)
        {
            this.data = data;
        }
        public int data { get; set; }
        public NodeTree left { get; set; }
        public NodeTree right { get; set; }
    }
    
    public class BinaryTree
    {
        private NodeTree head;

        public void add(int value)
        {
            if (head == null)
            {
                head = new NodeTree(value);;
            }
            else
            {
                NodeTree current = head;
                while (current != null)
                {
                    if (current.data < value )
                    {
                        if (current.right == null)
                        {
                            current.right = new NodeTree(value);
                            break;
                        }
                        else
                            current = current.right;
                    }
                    else
                    {
                        if (current.left == null) {
                            current.left = new NodeTree(value);
                            break;
                        }
                        else
                            current = current.left;
                    }
                }
            }
        }

        public bool search(int value)
        {
            NodeTree current = head;
            while (current != null)
            {
                if (current.data == value)
                    return true;
                else if(current.data > value)
                    current = current.left;
                else
                    current = current.right;
            }
            return false;
        }
        public void show()
        {
            List<NodeTree> stack = new List<NodeTree>();
            if (head != null)
                stack.push_end(head);
            NodeTree current;
            Console.WriteLine("Tree elements");
            while (stack.get_size() != 0)
            {
                current = stack.delete_end();
                stack.push_end(current.right);
                stack.push_end(current.left);
                Console.Write(current.data + " ");
            }
            Console.WriteLine("");
        }
    }
}