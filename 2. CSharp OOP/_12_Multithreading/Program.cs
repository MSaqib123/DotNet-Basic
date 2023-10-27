using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace _12_Multithreading
{
    internal class Program
    {

        //____ Synchoronouse_Method __
        static void DownloadFile()
        {
            Console.WriteLine("Synchoronuse_Method");
        }


        //____ Synchoronouse_Method __
        static async void DownloadFileAsync()
        {
           Console.WriteLine("Asynchoronuse_Method");
        }

        static void Main(string[] args)
        {
            //____________________________________ Multithreading (TPL) _______________________________________
            //Multithreading means that you can do multiple things at the same time in a computer program. It's like having many people working on different tasks simultaneously

            /*
                In C#, you can use the Task Parallel Library (TPL) to create and manage threads.
                Threads are like different paths of execution within a program.
                So, with multithreading, you can have different threads doing different things at the 
                same time, which makes your program faster and more responsive.
             */

            //_______________________________________ 1. Task ___________________________________
            #region Task
            //Starting Two  Task  Concurrently 
            //____________ 1. Task _______________
            Task Task1 = Task.Run(() =>
            {
                Console.WriteLine("Task 1 Start");
                //Some long-runing Task Here

                Console.WriteLine("Task 1 Completed");
            });

            //____________ 2. Task _______________
            Task Task2 = Task.Run(() =>
            {
                Console.WriteLine("Task 2 Start");
                //Some long-runing Task Here

                Console.WriteLine("Task 2 Completed");
            });

            //Wait for Both Task to Complete
            Task.WaitAll(Task1, Task2);


            Console.WriteLine("All Completed Task");
            Console.WriteLine();
            #endregion


            //_______________________________________ 2. Synchronouse method Vs  Asynchronouse method __________________________________
            #region Sync Vs Async


            /*
                Synchronous method Vs  Asynchronous method ?
                1. Sync  Execute  1 by 1 ,,,    if   user  make  3  request    , when 1st request wil completed then 2nd will start..
                2. Async   Execute  All  request at a Time .. if  user  make  3  request    then     all  request would be   made  ... 
             */

            #region Synchoronouse_Method
            //__________ *** 1. Synchoronnouse *** ______________
            //this  is  Simplete  metho ---> Jo abhi take hum  naa Methods bnay  han      wo Saraa  Synchoronus Methods Thaaa
            //Jab  Take  1 Method  Complete  Execute nhin hotaa  Dosraa Method   kabhi   bhi Execute nhotaa
            //--> means  1 time par  1 he method Execute ho ga
            //--> or  1 time par   1 he  Request  ho gee

            DownloadFile(); //--- 1st Request    start --- 
            DownloadFile(); //--- 2nd request    start --- if  1st   Request Completed
            DownloadFile(); //....
            DownloadFile(); //....

            //_____  Lakin Lakin   ____ kyaa hamari   WebSite / App   Porit  Dunyan me  1 he  Sks use kraa ga
            //_____ it will  10000 of  user  

            //_______ let:   ager  100 user   click on Download Button to Download file   ______
            //1st user downliadng ,  2nd user downloading will start  ,,,,,,,,,  ,,
            // so  What happends to    User  at   100 position   .. he has to  wait  99 users to  first Complete there  Downloading ...   
            // noooooooooooooooooooooo  maaaaannn
            #endregion


            #region Asynchronouse_Method
            //__________ *** 3. Asyncronise method *** _______________
            /*
             Using TPL, you can also perform tasks Asynchronously.
                Asynchronous means that you don't have to wait for one task
                to finish before starting another. Instead, you can start multiple tasks 
                at the same time and let the computer handle the order in which they complete.
                This can help you to optimize your program's performance and make it more efficient.
             */
            /*
                Asynchronous methods, on the other hand, allow multiple tasks to be executed simultaneously.
                1. Ager   100 user naa  ---> Request ke  ha to  ---> Sab request  ---> kar  Response Gy gaa
             */

            DownloadFileAsync();
            DownloadFileAsync();
            DownloadFileAsync();
            DownloadFileAsync();
            DownloadFileAsync();



            #endregion



            /*
                    OK  When To  Use    Async  &  Sync?
                    1.  if  have   small  Program or Project    then   go for   --> Sync  method .
                    2. if have   Complex large ERP , or  …      then   go  for  --->  Async  Method.

                    __ because  Async Take  All Request at 1 time     and  consume More  Memory in Cashaaa.. Soo   it not Good for Small Project 
            */
            #endregion


            //_______________________________________ 3. downloading File From Interb -->> by Async &  Sync __________________________________
            Console.WriteLine("\nStarting Download....");

            //____ To Calculate Time ____ b/w  Async , Sync   using
            Stopwatch stopwatch = new Stopwatch();  //agaa  parhin ga     DateTime me
            stopwatch.Start();


            //___________________ Synchronous download _________________________
            //1.  Loaded First  but  Slow
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            Console.WriteLine("Synchronous download completed in {0} seconds.", stopwatch.Elapsed.TotalSeconds);

            //2. Sync  take  Request  1 by 1   that take  so much time
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            DownloadFile("https://media.istockphoto.com/photos/generic-red-suv-on-a-white-background-side-view-picture-id1157655660?b=1&k=20&m=1157655660&s=612x612&w=0&h=ekNZlV17a3wd_yN9PhHXtIabO_zFo4qipCy2AZRpWUI=");
            Console.WriteLine("Synchronous download completed in {0} seconds.", stopwatch.Elapsed.TotalSeconds);

            //3.  If  there is   1000000000   of  Files then  what will happend


            stopwatch.Restart();


            //___________________ Asynchronous download _________________________
            //1.  Loaded  last because code  is last   ---->  but   Faster Then  Ever
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            Console.WriteLine("Asynchronous download completed in {0} seconds.", stopwatch.Elapsed.TotalSeconds);

            //2.  Asyncronus   Take All Request 1 time ... Not 1 by 1
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            DownloadFileAsync("https://images.unsplash.com/photo-1494976388531-d1058494cdd8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2Fyc3xlbnwwfHwwfHw%3D&w=1000&q=80").Wait();
            Console.WriteLine("Asynchronous download completed in {0} seconds.", stopwatch.Elapsed.TotalSeconds);

            //3.  Batter Choice for  Complex Data
            Console.ReadLine();
        }

        public static void DownloadFile(string url)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, "Syncfile.jpg");
        }

        public static async Task DownloadFileAsync(string url)
        {
            WebClient client = new WebClient();
            await client.DownloadFileTaskAsync(url, "Asyncfile.jpg");
        }

    }
}

