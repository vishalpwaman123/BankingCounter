using System;
using System.Collections.Generic;
using System.Text;

namespace BankingCastCounter
{
    class BankManipulation
    {

        public static void CashDeposition(LinkedList linkedList)
        {
            int flag = 1;
            while (flag == 1)
            {
                string name = FetchNameDetail(linkedList);
                if (name == null)
                {
                    continue;
                }
                Console.WriteLine("Enter Deposite Amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                int balance = linkedList.BalanceDepositionUpdation(name, amount);
                if (balance == 0)
                {
                    Console.WriteLine("Please Enter Valid Amount");
                    flag = 1;
                }
                else
                {
                     Console.WriteLine("Account Holder " + name + " Current Balance After Deposite is:\t" + balance);
                     flag = 0;
                }
                
            }
        }
        public static void WithDrawCash(LinkedList linkedList)
        {
            int flag = 1;
            
            while (flag == 1)
            {
                    string name = FetchNameDetail(linkedList);
                    if (name == null)
                    {
                    continue;
                    }
                    Console.WriteLine("Enter WithDrawal Amount");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    int balance = linkedList.BalanceUpdationWithdraw(name,amount);
                    if (balance == 0)
                    {
                        Console.WriteLine("Please Enter Valid Amount");
                        flag = 1;
                    }
                    else
                    {
                        Console.WriteLine("Account Holder " + name + " Current Balance After Deposite is:\t" + balance);
                        flag = 0;
                    }
                
                }
        }

        private static string FetchNameDetail(LinkedList linkedList)
        {
            Console.WriteLine("Enter Account Holder Name");
            String name = Console.ReadLine();
            if (linkedList.CustomerFound(name) == 1)
            {
                return name;
            }
            else
                Console.WriteLine("Please Enter Valid Account Holder Name");
                return null;

        }

    }
}
