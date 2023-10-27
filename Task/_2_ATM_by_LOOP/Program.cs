using System;

namespace _2_ATM_by_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //______________________________________ Bank ATM  _____________________________________________________
        #region ATM

        repeat:
            Console.WriteLine("__________________________");
            Console.WriteLine("Welcome in ATM");


            int balance = 15000;
            /*_____________________Single PIN________________
            do
            {
                Console.Write("Enter PIN : ");
                pin = Console.ReadLine();
            }
            while (pin != "123");
            */

            //string[] pinArray = new string[] {"123","saqib123","Nubaid123", "SirFarhan123" };
            //for (int i = 0; i < pinArray.Length; i++)
            //{
            //    string pin;
            //    do
            //    {
            //        Console.Write("Enter PIN : ");
            //        pin = Console.ReadLine();
            //    }
            //    while (pinArray[i] != pin);
            //    if (pinArray[i] == pin)
            //    {
            //        break;  
            //    }
            //}

            //_____________________ ArrayList PIN________________
            string[] pinArray = { "123", "saqib123", "Nubaid123", "SirFarhan123" };

            string pin;
            var result = "";

            do
            {
                Console.Write("Enter PIN : ");
                pin = Console.ReadLine();
                result = Array.Find(pinArray , x => x.ToString() == pin);
            }
            while (result != pin);

            //__success__
            Console.WriteLine("\nThanks for Entring in Our ATM\n");

        menu:
            Console.WriteLine("_________________Menu______________________");
            Console.WriteLine("1) check Balance \t 2) Fast Cash \t 3) ChangeAccount \t 4) Exit ");
            Console.Write("Enter Option : ");
            byte option = byte.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("\n__Your Balance is [" + balance + "]");
                goto menu;
            }
            else if (option == 2)
            {
            fastCash:
                Console.WriteLine("\n1) 500 \t 2) 1000 \t 3) 5000   \n 4) 10000 ");
                Console.Write("Enter Option : ");
                byte option2 = byte.Parse(Console.ReadLine());
                if (option2 == 1)
                {
                    balance = balance - 500;
                    Console.WriteLine("\n___500 Out => Your Remaining Balance is [" + balance + "]__\n");

                    Console.Write("More Transtion (y,n) : ");
                    char YN = char.Parse(Console.ReadLine());
                    if (YN == 'y' || YN == 'Y')
                    {
                        goto fastCash;
                    }
                    else
                    {
                        goto menu;
                    }
                }
                else if (option2 == 2)
                {
                    balance = balance - 1000;
                    Console.WriteLine("\n___1000 Out => Your Remaining Balance is [" + balance + "]__");

                    Console.Write("More Transtion (y,n) : ");
                    char YN = char.Parse(Console.ReadLine());
                    if (YN == 'y' || YN == 'Y')
                        if (YN == 'y' || YN == 'Y')
                        {
                            goto fastCash;
                        }
                        else
                        {
                            goto menu;
                        }
                }
                else if (option2 == 3)
                {
                    balance = balance - 5000;
                    Console.WriteLine("\n___5000 Out => Your Remaining Balance is [" + balance + "]__");


                    Console.Write("More Transtion (y,n) : ");
                    char YN = char.Parse(Console.ReadLine());
                    if (YN == 'y' || YN == 'Y')
                        if (YN == 'y' || YN == 'Y')
                        {
                            goto fastCash;
                        }
                        else
                        {
                            goto menu;
                        }
                }
                else if (option2 == 4)
                {
                    balance = balance - 10000;
                    Console.WriteLine("\n___10000 Out => Your Remaining Balance is [" + balance + "]__");

                    Console.Write("More Transtion (y,n) : ");
                    char YN = char.Parse(Console.ReadLine());
                    if (YN == 'y' || YN == 'Y')
                        if (YN == 'y' || YN == 'Y')
                        {
                            goto fastCash;
                        }
                        else
                        {
                            goto menu;
                        }
                }
                else
                {
                    Console.Write("Invalid Option");
                    goto menu;
                }
            }
            else if (option == 3)
            {
                goto repeat;
            }
            else if (option == 4)
            {
                Console.WriteLine("\n______Thanks For Visiting Our Bank Come Again______\n");
            }
            else
            {
                Console.WriteLine("\n______Invalid Entry______\n");
                goto menu;
            }

            #endregion

            //__________________________________ Bank Systen  _____________________________________________________

        }
    }
}
