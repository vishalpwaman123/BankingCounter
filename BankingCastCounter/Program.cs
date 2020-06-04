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
            Console.WriteLine(linkedList.isEmpty());
        }
    }
}
