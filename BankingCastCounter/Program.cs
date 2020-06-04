using System;

namespace BankingCastCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("Enter your Choice: \n 1.Create New Account \n 2.Cash Deposite \n 3.Cash Withdrawal \n 4.Display \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        linkedList.createAccount();
                        break;
                    case 2:
                        BankManipulation.CashDeposition(linkedList);
                        break;
                    case 3:
                        BankManipulation.WithDrawCash(linkedList);
                        break;
                    case 4:
                        linkedList.displayRecord();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }
                
            }
        }
    }
}
