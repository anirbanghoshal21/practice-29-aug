using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_implement
{
    class LinkedList
    {
        
            internal DoublyLinkedList head;
            void InsertNodeInFront(UserDoubleLinkedList list, int dataToInsert)
            {
                DoublyLinkedList node = new DoublyLinkedList(dataToInsert);
                node.next = list.head;
                list.head = node;
                node.prev = null;
                if (list.head != null)
                {
                    list.head.prev = node;
                }


            }



            void InsertAfter(DoublyLinkedList prevnode, int data)
            {
                if (prevnode == null)
                {
                    Console.WriteLine("cannot be null");
                    return;

                }


                DoublyLinkedList newnode = new DoublyLinkedList(data);
                newnode.next = prevnode.next;
                prevnode.next = newnode;
                newnode.prev = prevnode;
                if (newnode.next != null)
                {
                    newnode.next.prev = newnode;
                }

            }
            void InsertAtTheEnd(DoublyLinkedList list, int dataToInsert)
            {
                DoublyLinkedList node = new DoublyLinkedList(dataToInsert);
                if (list.head == null)
                {
                    list.prev = null;
                    list.head = node;
                    return;
                }
                DoublyLinkedListNodeDemo node1 = GetLastNode(list);
                node1.next = node;
                node.prev = node1;

            }

            private DoublyLinkedList GetLastNode(DoublyLinkedList list)
            {
                DoublyLinkedList tempnode = list.head;
                while (tempnode != null)
                {
                    tempnode = tempnode.next;

                }
                return tempnode;
            }
}
