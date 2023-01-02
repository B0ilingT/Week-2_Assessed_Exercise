using System;
using System.Collections.Generic;
using System.Text;

namespace Journal_Linked_List
{
    class Node<T> where T : IComparable
    {
        private T data;
        private Node<T> next;


        public Node(T item)
        {
            data = item;
            next = null;
        }
        public Node(T item, Node<T> list)
        {
            data = item;
            next = list;
        }
        public Node<T> Next
        {
            set { this.next = value; }
            get { return this.next; }
        }

        public T Data
        {
            set { this.data = value; }
            get { return this.data; }
        }

    }
}
