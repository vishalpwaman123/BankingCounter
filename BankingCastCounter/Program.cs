using System;

namespace BankingCastCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList linkedList = new LinkedList();
            linkedList.RecordInsertion("Vishal Wamankar", 60000);
            linkedList.RecordInsertion("Rahul Wamankar", 5000);
            linkedList.RecordInsertion("Ravi Vaishanav", 45000);
            linkedList.RecordInsertion("Mahesh Bhosale", 1000);
            linkedList.RecordInsertion("Akash Bhosale", 2000);
            linkedList.RecordInsertion("Shubham Bhakte", 5000);
            linkedList.RecordInsertion("Abhi Shinde", 3000);
            linkedList.RecordInsertion("Shraddha choudhary", 2000);  
            linkedList.RecordInsertion("priya ingale ", 3000);
            linkedList.RecordInsertion("Sunny takatwala", 5000);
            linkedList.RecordInsertion("Salman Chaiwala", 2000);
            linkedList.RecordInsertion("shahrukh panwala", 2000);
            linkedList.RecordInsertion("Amir Chole", 6000);
            linkedList.displayRecord();

            
            while (true)
            {
                Console.WriteLine("Enter your Choice: \n 1.Cash Deposite \n 2.Cash Withdrawal");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BankManipulation.CashDeposition(linkedList);
                        break;
                    case 2:
                        BankManipulation.WithDrawCash(linkedList);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }
                linkedList.displayRecord();
            }
        }
    }
}
