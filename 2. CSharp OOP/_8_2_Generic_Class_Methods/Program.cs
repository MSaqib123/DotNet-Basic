using System;

namespace _8_1_Generic_Class_Methods
{
    //_________________________ Generic Class _____________________________
    class myClass<T,A> //this is Generic class
    {
        //_______________GenericMethod_________________
        //public void GenericMethod<T, A>(T v1, A v2)
        public void GenericMethod(T v1, A v2)
        {
            Console.WriteLine("\n\n You Enter : " + v1);
            Console.WriteLine(" You Enter : " + v2 + "\n\n");
        }

        //_______________ Simple Method __________________
        public void simpleMethod()
        {
            Console.WriteLine("Pakistan ZindaBad");
        }



        //_______________ Array __________________
        private T[] arr = new T[5];
        public void setData(int index, T value)// T = int , string , bool , float , 
        {
            arr[index] = value;
        }
        public T getData(int index)
        {
            return arr[index];
        }

    }

    internal class Program
    {
        public void GenericMethod<T,A>(T v1, A v2)
        {
            Console.WriteLine(" You Enter : " + v1);
            Console.WriteLine(" You Enter : " + v2);
        }


        static void Main(string[] args)
        {
            //______________________________________________1. Generic Method _____________________________________
            #region 1. Generic Method
            Program p = new Program();
            p.GenericMethod<string, int>("pakistan", 25);
            p.GenericMethod<string, string>("Sajid ", "Employee");
            p.GenericMethod<string, int>("Sallary ", 250000);
            #endregion


            /*______________________________________________2. Generic Class ________________________________________*/
            //-- Ab hum ===> Mazeed Nawaab bnaa gayy 
            //-- hum chtaa han ===> humin     <string , int>  ===> yaaa  Baar Baaar na likhnaa paraa 
            //-- to phir Appp Class use krainag

            #region 2. Generic_Class
            //1. jis Tarhaa humaaraa pass  Generic Method  ===> Wassaa he    Generic Class hoti ha
            //2. class me humaa  baarr    DataType nhin btani partii ===> its Remain Static
            myClass<string,int> m = new myClass<string,int>();

            m.GenericMethod("Muhammad Saqib",25); //GenericMethod(25,"Pakistna");  Wrong Data Type assign
            m.GenericMethod("Rashid Ali", 45); //but   Data 

            //3. Generic Class me (Simple Method + Generic Method)  bhee bna sktaa han
            m.simpleMethod();


            //________ Array Set __________
            myClass<int, string> m1 = new myClass<int, string>();
            for (int i = 0; i < 5; i++)
            {
                m1.setData(i, i * 2);
            }

            //________ Array get __________
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Even Number : "+ m1.getData(i));
            }
            #endregion



        }
    }

}
