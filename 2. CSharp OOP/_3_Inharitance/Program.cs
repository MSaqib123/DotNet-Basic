using System;

namespace _3_Inharitance
{
    //_________________________________ 1. Single Inharitanc ____________________________
    #region 1. Single Inharitance

    class parent
    {
        public int id = 1;
        public string name = "Rahaman";
        public string email = "m43577535@gmail.com";
        public string designation = "Super";
        public int ATMPink = 123;
            
        public void showParent()
        {
            Console.WriteLine("this is parent methoe");
        }
    }

    class child/*drived(child)*/ : parent //base(parent) class
    {
        public void showchild()
        {
            Console.WriteLine("this is child method");
        }
    }
    #endregion

    //_________________________________ 2. Hierarchical Inharitance ____________________________
    #region 2. Hierarchical Inharitance

    class Employee
    {
        //__Common Attributs in  (tem,per)Employee   class
        public int id;
        public string name;
        public string email;
        public string desiganation;
    }
    class tempEmployee: Employee
    {
        //______________ Repetation of Code _________________
        //public int id;
        //public string name;
        //public string email;
        //public string desiganation;
        public int tempSaleryM;
        public int tempSaleryA;
    }
    class perEmployee : Employee
    {
        //______________ Repetation of Code _________________
        //public int id;
        //public string name;
        //public string email;
        //public string desiganation;
        //____________ Uniqe Attributes _______
        public int perSaleryM;
        public int perSaleryA;
    }
    #endregion

    #region Exemple of (Hierarchical)
    //----- 1 ----
    class lab
    {
        public string labsName;
        public string labTiming;
        public string labDays;
    }
    class Student : lab
    {
        public int id;
        public string stName;
        public string fName;
        public string dob;
        public string srNumber;
        //string labName;
        //string labTiming;

        public void info()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.stName);
            Console.WriteLine(this.fName);
            Console.WriteLine(this.srNumber);
            Console.WriteLine(this.dob);
            Console.WriteLine(this.srNumber);
            Console.WriteLine(this.labsName);
            Console.WriteLine(this.labTiming);
            Console.WriteLine(this.labDays);
        }
    }
    class Teacher : lab
    {

    }

    //----- 2 ----
    class myParent
    {

    }

    class child1 : myParent
    {

    }
    class child2 : myParent
    {

    }
    class clild3 : myParent 
    {

    }
    #endregion

    //_________________________________ 3. Multi-level Inharitance ____________________________
    #region Multilevel

    //1st
    class GrandFather
    {
        public void GrandFatherBankBalance() {
            Console.WriteLine("GrandFather Bank Balance");
        }
    }
    //2nd    Father ka  pass   GrandFather ke  Properties  aa gain
    class Father:GrandFather
    {
        public void FatherBankBalance ()
        {
            Console.WriteLine("MyFather Bank Balance");
        }
    }
    //3rd    Father kaa baad ==> childs ka  pass   Father ke  Properties  aa gain 
    class childs : Father
    {
        public void myBankBalance()
        {
            Console.WriteLine("My Bank Balance");
        }
    }
    

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //_________________________________________________ Inhariatance _________________________________________________
            //1. class 2nd class jo  kuch lati ha ===> inharitance         
            //2.  jasaa hum   Apnaa abaao Ajdaa saa kuch na kuch lata han ===> Zuban, mony , islam , aqida ....
            //----isi tarhaa jub hum  kisi class ko  kisi class me  ===> as a ==> ReletionShip  Use krtaa han ===> to Wo Class kuch na kuch lat ha ==> or dati ha

            //_________________________________________________ Types of Inharitance _____________________________________________
            //1. Single Inharitance
            //2. hericaly Inaritance
            //3. Multi Lavel Inharitance

            //_________________________________ 1. Single Inharitance ____________________________
            #region Single Inharitance
            //1. befor inharitance
            child c = new child();
            c.showchild();

            //2. after inhartiacne    ====>  parent ke propertis use kra gaa
            c.showParent();
            Console.WriteLine(c.id);
            Console.WriteLine("Asad ali " + c.name);
            Console.WriteLine(c.email);
            Console.WriteLine(c.designation);
            Console.WriteLine("My Father Bank Code : "+ c.ATMPink);
            #endregion

            //_________________________________ 2. Hierarchical Inharitance ____________________________
            #region Hierarchical Inhartiance
            //1. Before Inharitance 
            tempEmployee temC = new tempEmployee();
            temC.tempSaleryM = 123;
            temC.tempSaleryA = 123;

            perEmployee perC = new perEmployee();
            perC.perSaleryM = 123;
            perC.perSaleryA = 123;

            //2. After Inharitance
            temC.id = 1;
            temC.name = "Saqib";
            temC.email = "m43577535@gmail.com";

            perC.id = 1;
            perC.name = "Billal";
            perC.email = "Ahmad@gmail.com";
            #endregion

            #region Exemple
            Student st = new Student();
            st.id = 1;
            st.stName = "Rehman";
            st.fName = "Noman";
            st.srNumber = "101";
            st.dob = "10-5-1996";
            st.labsName = "Lab_5";
            st.labTiming = "3 am";
            st.labDays = "MDF";
            //______ Inharitance ka Concep ===> Gyaa Taall lanaa ===>  asaa nhin krtaa
            //Console.WriteLine(st.id);
            //Console.WriteLine(st.stName);
            //Console.WriteLine(st.fName);
            //Console.WriteLine(st.srNumber);
            //Console.WriteLine(st.dob);
            //Console.WriteLine(st.srNumber);
            //Console.WriteLine(st.labsName);
            //Console.WriteLine(st.labTiming);
            //Console.WriteLine(st.labDays);
            st.info();
            #endregion

            //_________________________________ 3. Multi-level Inharitance ____________________________
            #region
            //________  Nasal Dar Nasal  ===> Agaa jaanaa
            Console.WriteLine("\n");

            GrandFather gF = new GrandFather();
            gF.GrandFatherBankBalance();

            Father f = new Father();
            f.FatherBankBalance();

            childs ch = new childs();
            ch.myBankBalance();

            //________ After Multilevel Inharitance ________
            //--1---
            f.GrandFatherBankBalance();
            //--2--
            ch.FatherBankBalance();
            ch.GrandFatherBankBalance();

            #endregion

            //_________________________________ 4. Multiple Inharitance ____________________________
            //1)  1-Child ==ka=> 2 Father  ====>   not Posible in C#
            //2)  1-Class ===> 2 Class ===> ko  Inharit nhin kr skti
            //----> is Problem ka lya hum ======> (Interface)  use krtaa han ====> Aga  parhain gaa

            



        }
    }
}
