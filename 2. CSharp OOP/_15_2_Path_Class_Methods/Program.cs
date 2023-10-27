using System;
using System.IO;

namespace _9_3_Path_Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__________________________________________ Path Class _____________________________________________
            //_________________________ Path + Directory _______________________________
            #region 1. Path + Directory
            //__________ 1. fullPath +  file_Name ______________
            var fullPath = Path.GetFullPath("text.txt");
            Console.WriteLine(fullPath);

            //__________ 2. DirectoryName (Location) ______________
            var directoryName = Path.GetDirectoryName(fullPath);
            Console.WriteLine(directoryName);

            //__________ 3. GetRandomFileName ______________
            //Apni Marzi sa kuch bhee     (1. ak5fbavp.w53)   (2. bnejelvl.vfi)
            var randomFile = Path.GetRandomFileName();
            Console.WriteLine(randomFile);
            #endregion

            //_________________________ FileName,Extention , without_Extention _______________________________
            #region 2.  FileName,Extention , without_Extention
            var fileFullPath = Path.GetFullPath("text.txt");
            Console.WriteLine("\n" + fileFullPath);

            //____________ 1. GetfileName ________________
            var fileName = Path.GetFileName(fileFullPath);
            Console.WriteLine("___FileName only : " + fileName);

            //____________ 2. Extention of File ________________
            var onlyExtension = Path.GetExtension(fileFullPath);
            Console.WriteLine("___Only Extention : " + onlyExtension);

            //____________ 3. Filename without Extension ________________
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileFullPath);
            Console.WriteLine("___FileName without Extention : " + fileNameWithoutExtension);

            #endregion

            //_________________________ Path.Combine _______________________________
            #region Path.Combine
            string userImage = "UserImage.png"; //user Browes kr rhaa ha
            string locaton = "/home/Image/";    //location

            string fileCompine = Path.Combine(locaton,userImage);  //this fullLocation  will Saved in Database
            Console.WriteLine("\n\n________FileCombine : " + fileCompine);
            #endregion
        }
    }
}
