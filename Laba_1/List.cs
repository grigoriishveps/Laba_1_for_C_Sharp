using System;
namespace Laba_1
{
    public class Node<T>
    {
        public Node(T data)
        {
            this.data = data;
        }
        public T data { get; set; }
        public Node<T> next { get; set; }
        public Node<T> prev { get; set; }
    }
    
    public class List<T>
    {
        Node<T> head; 
        Node<T> tail; 
        int size;
        
        public void push_end(T data) {
            if (data == null)
                return;
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                node.prev = tail;
                tail.next = node;
            }
            tail = node;
            size++;
        }
        
        public void push_start(T data) {
            if (data == null)
                return;
            Node<T> node = new Node<T>(data);

            if (head != null)
                head.prev = node;
            else
                tail = node;
            node.next = head;
            head = node;
            size++;
        }

        public T delete_end()
        {
            if (tail == null)
                throw new Exception("Индекс превышает размер списка");
            
            Node<T> result = null;
            result = tail;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
            }
            size--;
            
            return result.data;
        }
        
        public T delete_start()
        {
            if (head == null)
                throw new Exception("Индекс превышает размер списка");
            
            Node<T> result = null;
            result = head;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            size--;
            return result.data;
        }

        public void insert_elem(T data, int index)
        {
            if (size == 0)
                throw new Exception("Индекс превышает размер списка");
            else if (index == 0)
                push_start(data);
            else if (index == size)
            {
                push_end(data);
                // Node<T> cur = new Node<T>(data);
                // tail.prev.next = cur;
                // cur = tail.prev;
                // cur.next = tail;
            }
            else
            {
                Node<T> current = head;
                Node<T> new_elem = new Node<T>(data);
                
                while (--index !=0 )
                {
                    current = current.next;
                }

                new_elem.next = current.next;
                new_elem.next.prev = new_elem;
                current.next = new_elem;
                new_elem.prev = current;
            }
        }

        public T delete_elem(int index)
        {
            if (size == 0)
                throw new Exception("Индекс превышает размер списка");
            else if (index == size - 1)
                return delete_end();
            else if (index == 0)
                return delete_start();
            else
            {
                Node<T> current = head;
                Node<T> result = current;
                
                while (--index !=0 )
                {
                    current = current.next;
                    
                }
                result = current.next;
                current.next = result.next;
                result.next.prev = current;
                
                return result.data;
            }
        }

        public T get_elem(int index)
        {
            if (size == 0)
                throw new Exception("Индекс превышает размер списка");
            else if (index == size - 1)
                return tail.data;
            else if (index == 0)
                return head.data;
            else
            {
                Node<T> current = head;
                head = tail;
                while (index-- !=0 )
                {
                    current = current.next;
                }
                return current.data;
            }
        }
        public void reverse()
        {
            Node<T> node = head;
            Node<T> current = tail;
            head = tail;
            while (current != null)
            {
                current.next = current.prev;
                current.prev = null;
                current = current.next;
            }

            tail = node;
        }

        public void show()
        {
            Node<T> current = head;
            Console.WriteLine("List content: ");
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine("");
        }

        public int get_size()
        {
            return size;
        }
    }
}