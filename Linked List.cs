using System;
using System.Collections.Generic;
using System.Text;

namespace Journal_Linked_List
{
    class LinkListGen<T> where T : IComparable
    {
        private Node<T> list; //default value – empty list

        public LinkListGen()
        {
            list = null; //set to null
        }
        public void AddItem(T item) //add item to front of list
        {
            list = new Node<T>(item, list);
        }
        public void Sort()
        {
            Node<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();

            while (temp != null)
            {
                newList.InsertInOrder(temp.Data);
                temp = temp.Next;
            }
            list = newList.list;
        }

        public string DisplayItems() //write items to string and return
        {
            Node<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer += temp.Data.ToString();
                buffer += "\n";
                temp = temp.Next;
            }
            return buffer;
        }
        public void AppendItem(T item)
        {
            Node<T> temp = list;

            if (temp == null)
                list = new Node<T>(item);
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node<T>(item);
            }
        }
        public void RemoveItem(T item)
        {
            Node<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) != 0)
                    newList.AppendItem(temp.Data);
                  temp = temp.Next;  
            }
            list = newList.list;
        }
        public void InsertInOrder(T item)
        {
            Node<T> temp = list;
            Boolean itemAdded = false;
            LinkListGen<T> newList = new LinkListGen<T>();
            if (list == null)
                AddItem(item);
            else
            {
                while (temp != null)
                {
                    if (item.CompareTo(temp.Data) < 0) // if temp.data is not greater than the item to add in order then add temp.data to the list
                    {
                        newList.AppendItem(temp.Data);
                    }
                    if (item.CompareTo(temp.Data) > 0) // if temp.data is greater than the item to add then add the item and then add temp.data to the list
                    {
                        if (itemAdded == false)
                        {
                            newList.AppendItem(item);
                            newList.AppendItem(temp.Data);
                            itemAdded = true;
                        }
                    }
                    temp = temp.Next;
                }
                list = newList.list; // overwrite old list with new list
            }
        }

        public int Count()
        {
            int count = 0;
            Node<T> NumOfItem = list;
            while (NumOfItem != null)
            {
                NumOfItem = NumOfItem.Next;
                count++;
            }

            return count;
        }

        public bool IsPresentItem(T data)
        {
            Node<T> num = list;
            while (num != null)
            {
                if (data.Equals(num.Data))
                {
                    return true;
                }
                num = num.Next;
            }
            return false;
        }       

    }
}
