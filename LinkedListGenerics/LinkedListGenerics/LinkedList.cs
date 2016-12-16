using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenerics
{
    class LinkedList<TItem>
    {
        private class Node
        {
            private TItem item;
            private Node next;

            public Node(TItem item, Node next)
            { this.item = item;
                this.next = next;
            }

            public TItem getItem { get { return item; } }
            public Node getNext { get{ return next; } }

           
        }

        private Node head;

        public void addToHead(TItem item)
        { var newHead = new Node(item, head);
            this.head = newHead;
        }

        public override string ToString()
        {
            return ToString(item => item.ToString());
        }


        public string ToString(Format<TItem> formatter)
        {
            var result = new StringBuilder();
            result.Append("[");

            var node = head;
            while (node != null)
            {
                // Here is where the magic happens: call the 
                // formatter we received as input in order 
                // to convert each item to a string 
                string itemAsString = formatter(node.getItem);


                result.Append(itemAsString);
                result.Append(", ");



                node = node.getNext;
            }


            result.Append("]");
            return result.ToString();


        }
    }

    public delegate string Format<T>(T item);
}