using System;

namespace BankingCastCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Banking Cash Counter");
            LinkedList linkedList = new LinkedList();
            linkedList.insertData("Vishal Wamankar", 27500);
            linkedList.insertData("Ravi Vaishanav", 3600);
            linkedList.displayRecord();
            
            Console.WriteLine("Node Empty Status :"+linkedList.isEmpty());
            Console.WriteLine("\n");

            linkedList.displayRecord();

            int status = linkedList.RemoveNote("Ravi Vaishanav");
            if(status==1)
            {
                Console.WriteLine("Data Found");
            }
            else
            {
                Console.WriteLine("Data Not Found");
            }
            linkedList.displayRecord();
        }
    }
}
