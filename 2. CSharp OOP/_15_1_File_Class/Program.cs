using System;
using System.IO;

namespace _9_2_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //______________________________________ File Class _______________________________________
            //1. File Class ==>  Located in   (System.IO)   ===> NameSpace
            //2. its Used to     Work  ===> With Files
            //------- Methods -------
            /*
                1.     AppendText()         Add  Text To Files  => at the End
                2.     Copy()               Copies Files
                3.     Create()             Create or OverWrite  File
                3.     Delete()             Delete File
                3.     Exists()             Test  files Exist or Not
                3.     ReadAllText()        Read Content of File
                3.     Replace()            Replace  Content  ===> with Content of Other Files 
                3.     Replace()            Create new Files  ===> write The Content ====> if File Exist  overWrite it
             */

            /*____________________________________ 1. Default Location ____________________________________ */
            #region Created_File => Default_Location
            //--->Project\bin\Debug\netcoreapp3.1   Save

            //_______ Create File + Text _______
            string text = "Hello, I Created This file App ko nhin  Dekhon gaa main yaa OK";
            File.WriteAllText("fileName.txt", text);   //Overwrite The Text

            //_______ Read  File Text _______
            if (File.Exists("fileName.txt"))
            {
                string readText = File.ReadAllText("fileName.txt");
                Console.WriteLine(readText);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File Not Exist");
            }
            #endregion

        }
    }
}
