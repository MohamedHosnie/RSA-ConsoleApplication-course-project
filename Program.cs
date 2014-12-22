using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                BigInt A, B;
                Console.WriteLine();
                Console.WriteLine("1- Add");
                Console.WriteLine("2- Subtract");
                Console.WriteLine("3- Divide");
                Console.WriteLine("4- Multiply");
                Console.WriteLine("5- Even/Odd");
                Console.WriteLine("6- Power");
                Console.WriteLine("7- Encryption");
                Console.WriteLine("8- Decryption");
                Console.WriteLine();

                Console.Write("Your choice: ");
                Char choice;
                choice = Char.Parse(Console.ReadLine());

                if ( choice != '7' && choice != '8' )
                {
                    String N1, N2;
                    Console.Write("======================\nEnter first number: ");
                    N1 = Console.ReadLine();
                    Console.Write("Enter second number: ");
                    N2 = Console.ReadLine();

                    //StringBuilder S1, S2;
                    //S1 = new StringBuilder(N1);
                    //S2 = new StringBuilder(N2);
                    A = new BigInt(N1);
                    B = new BigInt(N2);

                    BigInt res;
                    BigInt[] res2 = new BigInt[2];
                    Console.Write("======================\nResult: ");

                switch(choice)
                {
                    case '1':
                        res = A + B;
                        BigInt.res(res);
                        break;

                    case '2':
                        res = A - B;
                        BigInt.res(res);
                        break;

                    case '3':
                        res2 = A / B;
                        BigInt.res(res2[0]);
                        Console.Write("Remainder: ");
                        BigInt.res(res2[1]);
                        break;

                    case '4':
                        res = A * B;
                        BigInt.res(res);
                        break;

                    case '5':
                        if (BigInt.Even(A) && BigInt.Even(B))
                            Console.WriteLine("Both numbers are even.");
                        else if (BigInt.Even(A) || BigInt.Even(B))
                            Console.WriteLine("One of the numbers is even.");
                        else
                            Console.WriteLine("Both numbers are odd.");
                        break;

                    case '6':
                        //res = BigInt.Power(A, B);
                        //BigInt.res(res);
                        break;
                        
                    default:
                        break;
                }
                }

                else
                {
                    String ed, n, input;
                    BigInt res;

                    switch(choice)
                    {
                        case '7':
                            Console.Write("Enter E: ");
                            ed = Console.ReadLine();
                            Console.Write("Enter N: ");
                            n = Console.ReadLine();
                            Console.Write("Enter the message to be encrypted: ");
                            input = Console.ReadLine();

                            BigInt ED = new BigInt(ed);
                            BigInt N = new BigInt(n);
                            BigInt M = new BigInt(input);
                            res = BigInt.En_Decrytion(ED, N , M);
                            Console.Write("======================\nThe encrypted message: ");
                            BigInt.res(res);
                            break;

                    case '8':
                            Console.Write("Enter D: ");
                            ed = Console.ReadLine();
                            Console.Write("Enter N: ");
                            n = Console.ReadLine();
                            Console.Write("Enter the message to be decrypted: ");
                            input = Console.ReadLine();

                            BigInt D = new BigInt(ed);
                            BigInt N2 = new BigInt(n);
                            BigInt M2 = new BigInt(input);
                            res = BigInt.En_Decrytion(D, N2 , M2);
                            Console.Write("======================\nThe decrypted message: ");
                            BigInt.res(res);
                            break;
                        
                        default:
                            break;
                    }
                }

                Console.Write("======================\n");
            }
        }
    }
}
