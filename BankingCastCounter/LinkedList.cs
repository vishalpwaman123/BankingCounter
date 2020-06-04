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

            public Node
                 (string name, double cash)
            {
                this.name = name;
                this.cash = cash;
            }
        }

        //To check the LinkedList is Empty or Not
        public bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
    }
}
