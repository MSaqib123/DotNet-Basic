using System;

namespace _6_1_Jump_Statemens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //______________________________________Jumb Statements _____________________________________________________
            //Jump Statements ===> are used to  Tirminate/Repeate  Loop
            //1. break      (Tirminate Complete Loop)
            //2. continue   (Tirminate single Loop inside Loop)
            //3. goto       (Repeat the Loop)

            //______________________________________ 1. break _____________________________________________________
            #region break
            //break statement will  break Complete Loop
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==4)
            //    {
            //        Console.WriteLine("\n__break_Loop on 4th_Number ");
            //        break;
            //    }
            //    Console.WriteLine(i + " : Loop 1-10 ");
            //}

            //Console.WriteLine("__Loop is breaked\n");
            #endregion

            //______________________________________ 2. Continues _____________________________________________________
            #region Continues
            //continues  statement will break     particular Loop inside Loop
            //for (int i = 0; i < 10; i++)
            //{
            //    //if (i == 4)
            //    //{
            //    //    Console.WriteLine("\n__continu_ will break ---Curent Loop-- \n");
            //    //    continue;
            //    //}
            //    //if (i>=4 && i<=7)
            //    //{
            //    //    Console.WriteLine("\n__continue_Loop accept(4,5,6,7) \n");
            //    //    continue;
            //    //}
            //    Console.WriteLine(i + " : Loop 1-10 ");
            //}
            #endregion

            //_____Task______
            #region Task on Continue,Break  + Infinite_Loop
            //for (;;)
            //{

            //}
            #endregion


            //______________________________________ 3. Goto  _____________________________________________________
            #region GoTo
            ////code run  line by line
            ////if We Want To   Scipe Code of Line    and wanna go to   (bottom,top) again

            //Console.WriteLine("1  Line");
            //Console.WriteLine("2  Line");
            //Console.WriteLine("3  Line  ==> goto Line_7");
            //goto one;

            //Console.WriteLine("4  Line");
            //Console.WriteLine("5  Line");
            //Console.WriteLine("6  Line");

            //one:
            //Console.WriteLine("\n\n\n7  Line  jumping form Line_3");
            //Console.WriteLine("8  Line\n");


            //Console.WriteLine("9  Line");

        #endregion


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

                string[] pinArray = { "123", "saqib123", "Nubaid123", "SirFarhan123" };

                string pin;
                var result = "";
                
                do
                {
                    Console.Write("Enter PIN : ");
                    pin = Console.ReadLine();
                    result = Array.Find(pinArray, x => x.ToString() == pin);
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
                else if(option == 4)
                {
                    Console.WriteLine("\n______Thanks For Visiting Our Bank Come Again______\n");
                }
                else
                {
                    Console.WriteLine("\n______Invalid Entry______\n");
                    goto menu;
                }

                #endregion

        }
    }
}
