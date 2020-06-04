using System;
using System.Collections.Generic;
using System.Text;

namespace BankingCastCounter
{

    public class LinkedList
    {
        Node head;
        internal static bool checkCustomers;

        public class Node
        {
            public String name;
            public double cash;
            public Node next;

            public Node(string name, double cash)
            {
                this.name = name;
                this.cash = cash;
                this.next = null;
            }
        }

        //check the LinkedList is Not Empty 
        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Node insertData(string name, double cash)
        {
            if (name !=null && cash != 0.0 && name !=" ")
            {
                Node newNode = new Node(name, cash);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node LeastPosition = head;
                    while (LeastPosition.next != null)
                    {
                        LeastPosition = LeastPosition.next;
                    }
                    LeastPosition.next = newNode;
                }
            }
            else
            {
                Console.WriteLine("Data are Invalid and Please Enter Valid Data");
            }
            return head;
        }

        public void displayRecord()
        {
            Node LeastPosition = head;
            while (LeastPosition != null)
            {
                Console.WriteLine("Name:" + LeastPosition.name + "\t" + "Account Balance:" + LeastPosition.cash);
                LeastPosition = LeastPosition.next;
            }
        }

        //To remove front Node Data
        public Node removeFront()
        {
            Node firstPos = head;
            head = head.next;
            firstPos.next = null;
            return head;
        }
    }

}
