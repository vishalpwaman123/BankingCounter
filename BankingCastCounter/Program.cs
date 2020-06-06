using System;

namespace BankingCastCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Flags = 0,MAX=100;
            int TotalPeople = 0;
            int m=0, i = 0, Total=0, Counter=1;
            string[] PeopleQueue = new string[MAX];
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("1] Enter Total Number Of People\n2] Manipulation Transaction \n3] Exit");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("\n \n \n Please Enter Total Number Of People Enter In Bank:");
                        Total = Convert.ToInt32(Console.ReadLine());
                        Flags = 1;
                        break;
                    case 2:
                        Flags = 0;
                        break;
                    case 3:
                        return; 
                    default :
                        Console.WriteLine("Invalid Option Please Enter valid option");
                        break;

                }

                TotalPeople = TotalPeople + Total;
                while (TotalPeople >= (i+1) && Flags!=0)
                {
                    Console.WriteLine("Enter " + (i + 1) + " Person Name :");
                    PeopleQueue[i++] = Console.ReadLine();
                }
                
                Flags = 1;
                while (Flags==1)
                {
                    Console.WriteLine("Enter your Choice: \n 1.Create New Account \n 2.Cash Deposite \n 3.Cash Withdrawal \n 4.Display \n 5.Add People In Queue \n 6.Exit");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            if (Counter<=TotalPeople)
                            {
                                linkedList.createAccount(PeopleQueue[m]);
                                Counter++;
                                m++;
                            }else
                            {
                                Console.WriteLine("\n \n No One Remaining In Queue");
                                Flags = 0;
                            }
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
                            Flags = 0;
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }

                }
            }
        }
    }
}
