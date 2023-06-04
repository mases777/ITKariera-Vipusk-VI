﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha02
{
    public class Node
    {
        private object element;

        public object Element
        {
            get { return element; }
            set { element = value; }
        }
        private Node next;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(object element)
        {
            this.element = element;
            next = null;
        }
    }
    
    public class DynamicList
    {
        private Node head;
        private Node tail;
        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (head == null)
            {
                Node next = new Node(item);
                this.head = next;
                this.tail = next;
            }
            else
            {
                Node next = new Node(item, tail);
                this.tail = next;
            }
            this.count++;
        }
        public object Remove(int index)
        {
            Object item = null;
            Node current = head;
            Node previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == i)
                {
                    item = current.Element;
                    previous.Next = current.Next;
                    break;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return item;
        }


        public int Remove(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    Remove(index);
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }
        public int IndexOf(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {                    
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(object item)
        {
            Node current = head;
            while (current != null) 
            {
                if (current.Element.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public object this[int index]
        {
            get
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        return current.Element;
                    }
                    i++;
                    current = current.Next;
                }
                return null;
            }
            set 
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.Element = value;
                    }
                    i++;
                    current = current.Next;
                }                
            }
        }



    }
}
