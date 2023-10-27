using System;

namespace _1_Resturent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.Write("Enter Amount (at lest 1000): ");
            bool amountInt = int.TryParse(Console.ReadLine(),out amount);
            //____Veryfy int____
            if (amountInt)
            {
                if (amount >= 1000)
                {
                    Console.WriteLine("Welcome\nYour Amout : " + amount);
                    Console.WriteLine("============= Select Resturents =================");
                    Console.WriteLine("1) Chinees Resturent \t\t 2) Pakistani Resturents");
                    Console.Write("Select Option :");
                    int option;
                    bool optionInt = int.TryParse(Console.ReadLine(), out option);
                    //____Veryfy int____
                    if (optionInt)
                    {
                        //______Chinees________
                        if (option==1)
                        {
                            Console.WriteLine("\n---Welcome To Chineer Resturents---");
                            Console.WriteLine("1) Chewmen \t\t 2) Soop");
                            Console.Write("Select Item : ");
                            int item;
                            bool itemInt = int.TryParse(Console.ReadLine(), out item);
                            if (itemInt)
                            {
                                //______1_______
                                if (item == 1)
                                {
                                    Console.WriteLine("-----> You Selected Chewment = 1500Rs <------");
                                    Console.Write("Order (y,n) : ");
                                    char yesNo = Convert.ToChar(Console.ReadLine());
                                    if (yesNo == 'y')
                                    {
                                        if (amount < 1500)
                                        {
                                            Console.WriteLine("\n-----> Offs  Low  Amout : " + amount + "<------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n-----> Order Placed Successfuly <------");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n-----> Order Canceled <------");
                                    }
                                }
                                //______2_______
                                else if (item == 2)
                                {
                                    Console.WriteLine("-----> You Selected Soop = 1000Rs <------");
                                    Console.Write("Order (y,n) : ");
                                    char yesNo = Convert.ToChar(Console.ReadLine());
                                    if (yesNo == 'y')
                                    {
                                        if (amount < 1000)
                                        {
                                            Console.WriteLine("\n-----> Offs  Low  Amout : " + amount + "<------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n-----> Order Placed Successfuly <------");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n-----> Order Canceled <------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n-----> Out of Item <------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please (1,2) option");
                            }
                            
                        }
                        //______Pakistani________
                        else if (option == 2)
                        {
                            Console.WriteLine("\n---Welcome To Pakistani Resturents---");
                            Console.WriteLine("1) Baryani \t\t 2) CheckenPalow");
                            Console.Write("Select Item : ");
                            int item;
                            bool itemInt = int.TryParse(Console.ReadLine(), out item);
                            if (itemInt)
                            {
                                //______1_______
                                if (item == 1)
                                {
                                    Console.WriteLine("\n-----> You Selected Baryani = 1500Rs <------");
                                    Console.Write("Order (y,n) : ");
                                    char yesNo = Convert.ToChar(Console.ReadLine());
                                    if (yesNo == 'y')
                                    {
                                        if (amount < 1200)
                                        {
                                            Console.WriteLine("\n-----> Offs  Low  Amout : " + amount + "<------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n-----> Order Placed Successfuly <------");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n-----> Order Canceled <------");
                                    }
                                }
                                //______2_______
                                else if (item == 2)
                                {
                                    Console.WriteLine("\n-----> You Selected CheckenPalow = 1300 Rs <------");
                                    Console.Write("Order (y,n) : ");
                                    char yesNo = Convert.ToChar(Console.ReadLine());
                                    if (yesNo == 'y')
                                    {
                                        if (amount < 1300)
                                        {
                                            Console.WriteLine("\n-----> Offs  Low  Amout : " + amount + "<------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n-----> Order Placed Successfuly <------");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n-----> Order Canceled <------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n-----> Out of Item <------");
                                }

                            }

                        }
                        else
                        {
                            Console.WriteLine("------- Please Select Resturent -------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter The Option (1, 2)  Not 'String' ");
                    }
                }
                else
                {
                    Console.WriteLine("Amout Should Be Greater Then 100");
                }
                
            }
            else
            {
                Console.WriteLine("Enter The Amout Not 'String' ");
            }

        }
    }
}
