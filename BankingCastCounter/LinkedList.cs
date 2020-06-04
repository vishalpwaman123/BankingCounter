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
            public int cash;
            public Node next;

            public Node(string name, int cash)
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
        public void createAccount()
        {
            Console.WriteLine("Enter Account Holder Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account Holder Initial Cash :");
            int amount = Convert.ToInt32(Console.ReadLine());
            RecordInsertion(name,amount);

        }

        public Node RecordInsertion(string name, int cash)
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
        public void removeFront()
        {
            Node firstPos = head;
            head = head.next;
            firstPos.next = null;
            
        }

        public int RemoveNote(string Name)
        {
            Node firstPos = head;
            if (head == null)
                return 0;

            while (firstPos != null)
            {
                if (firstPos.name == Name)
                {
                    return 1;
                }
              firstPos = firstPos.next;
            }
            return 0;
        }

        public int CustomerFound(string name)
        {
            Node firstPosition = head;
            if (head != null)
            {
                while (firstPosition != null)
                {
                    if (firstPosition.name == name)
                        return 1;
                    firstPosition = firstPosition.next;
                }
            }
            return 0;
        }

        public int BalanceDepositionUpdation(string name, int amount)
        {
            Node firstPosition = head;
            if (head != null)
            {
                while (firstPosition != null)
                {
                    if (firstPosition.name == name)
                    {
                        if ((firstPosition.cash + amount) >= firstPosition.cash)
                        {
                            firstPosition.cash = firstPosition.cash + amount;
                            break;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    firstPosition = firstPosition.next;
                }
            }
            return firstPosition.cash;
        }

        public int BalanceUpdationWithdraw(string name, int amount)
        {
            Node firstPosition = head;
            if (head != null)
            {
                while (firstPosition != null)
                {
                    if (firstPosition.name == name)
                    {
                        if ((firstPosition.cash - amount) >= 0)
                        {
                            firstPosition.cash = firstPosition.cash - amount;
                            break;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    firstPosition = firstPosition.next;
                }
            }
            return firstPosition.cash;
        }

    }

}
