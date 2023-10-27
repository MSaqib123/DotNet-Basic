using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _3_BankSystem_By_OOP.UI
{
    public static class validator
    {
        //__ Using Generic Type  ==>   T Convert<T>     ===>   where  (T) is type of Inpute
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;
            while  (!valid) //not validate The Repeat Loop
            {
                userInput = Utility.GetUserInput(prompt);
                try
                {
                    var convertor = TypeDescriptor.GetConverter(typeof(T)); //T ko Convert kraa ga
                    if (convertor != null)
                    {
                        return (T)convertor.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine("Invalid INput. Try Again.");
                    Utility.PrintMessage("Invlaid Input. Try Again.",false);

                }
            }
            return default;
        }


    }
}
