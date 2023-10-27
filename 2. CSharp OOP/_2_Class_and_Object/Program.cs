using System;

namespace _2_Class_and_Object
{
    #region 1. Syntax Object & Class
    //______Class1_____
    internal class class1
    {
        public void message()
        {
            Console.WriteLine("This is Class 1");
        }
    }

    //______Class2_____
    internal class class2
    {
        public void message()
        {
            Console.WriteLine("This is Class 2");
        }
    }
    #endregion

    #region 2. using Field and Behaviours
    //____________________ Parent Class _______________________
    internal class Parent
    {
        //Variable
        public string name = "Saqib";
        int age = 25;

        //functon   (parameterize fn , non-parameterirze fn)
        public void info(string name, int age)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + name);
        }
    }
    #endregion

    #region 3. static and Static  Field,Behaviours
    internal class myClass
    {
        //_________None Static__________
        public string notStatic = "Not Static";
        public void notStaticFn()
        {
            Console.WriteLine("Pakistan");
        }

        //_________Static__________ static matatic will called withou making    object of this class
        static public string staticV = "Not Static\n";
        static public void StaticFn()
        {
            Console.WriteLine("Pakistan");
        }
    }
    #endregion

    #region 4. Constractor
    #region 1. Constractor
    internal class myConstractor
    {
        //______Constractor______
        public myConstractor()
        {
            //----constractor me Jo kuch bhee Dalin gaa---
            //wo By Default  On  Class Runing   me    Show ho gy gaa
            Console.WriteLine("This is Constractgor Message");
        }
    }
    #endregion

    #region 2. Non-parameteri  & parameter const
    internal class yourConstractor
    {
        //______1. Non-Parametrize Constroctor______
        public yourConstractor()
        {
            Console.WriteLine("Non-parametrize Constructor");
        }

        //______2. Parametrize Constroctor ______
        public yourConstractor(string name)
        {
            Console.WriteLine("parametrize Constructor === Your Name : " + name);
        }
        public yourConstractor(string name, int age)
        {
            Console.WriteLine("parametrize Constructor === Your Name : " + name + " = Your Age : " + age);
        }

    }
    #endregion

    #region 3. Static Constructor
    internal class stConst
    {
        public stConst()
        {
            Console.WriteLine("basic Constractor");
        }

        static stConst()
        {
            Console.WriteLine("static Constractor");
        }

        public stConst(string name)
        {
            Console.WriteLine("static Constractor" + name);
        }

        //______Paramter not Allowed_______
        //static stConst(string name)
        //{
        //    Console.WriteLine("Parameteriz Cons");
        //}

    }
    #endregion

    #region 5. Private Constractor    (copy Constractor Samjh nhin ayaa)
    internal class privateConstrator
    {
        //___Private Constroctor___ khud nhin work krtaa
        private  privateConstrator()
        {
        }
        //____overLoaded / paramertriz constractor___
        /// <summary>
        /// --- UserName Required ---
        /// </summary>
        /// <param name="userName"></param>
        public privateConstrator(string userName)
        {
            Console.WriteLine("Your Name : " + userName);
        }
    }

    #endregion

    #endregion

    #region 5. Static_Class
    static class stClass
    {
        static stClass()
        {

        }
        static void show()
        {

        }
    }
    #endregion

    #region 6. Disctration Method
    //____Base Class____
    class distractionClass
    {
        //____Destractive Method____
        ~distractionClass()
        {
            //only used to  FreeUp Memory Space  ==> Which is Allocated by  Variables and Objects
        }
    }

    
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //___________________________________1. Class & Object_______________________________________
            //class are Made in   NameSpace  === > (nameSpace is Collacetion of class)
            #region Syntax Class & Object
            //______Class_____
            //class is a template for object,  

            /* ____ 
                class ka  Against  ===>  hum  Object Bnata han
                kyun ===> us class ka  +==> methods or properties use krnaa ka lya
                1st class sa 2nd class me humm ===> proprites or method   ===> without Object ===> Use nhiin kr sktaa
            */

            //______Object_____
            //an object is instance of an class

            class1 obj1 = new class1();/*object insName = ___new constructon()*/  //class ka name saa bnaa haa  ===>
            //new Alocate The Memory In Ram


            obj1.message();


            class2 obj2 = new class2(); 
            obj2.message();

            #endregion


            //___________________________________2. Using FN & Properties  (fields , Behaviours)________________________________
            #region Fields & Behavirous
            Parent p = new Parent();
            //___Behaviours is Showing____
            p.info("Saqib",25);
            //___ Name, age is not Visible____ Why??
            //___ === fields , Behaviours   are    ByDefault ===> (private) <===== hotaa hana

            //___Making public Name____
            Console.WriteLine(p.name);
            #endregion

            //___________________________________3. Static  (Variables & Function) 2nd Class________________________________
            #region static & noneStatic 
            //_______None Static Variable Out______________
            myClass c = new myClass();
            Console.WriteLine(c.notStatic);
            c.notStaticFn();

            //_______Static Variable , Method______________
            //static fields & behavirous  always access by the  Name of Class  ====> not Object constructors
            //static ka Object  nhin bnataa
            Console.Write(myClass.staticV);
            myClass.StaticFn();
            #endregion

            //___________________________________4. Constractor ________________________________
            #region Constractor
            //1. Constractor
            //2. Constractor not parameterize
            //2.1 Contractor parameteriz
            //2.2 Constractor overloading
            //3. static Constractor
            //4. Copy Constructor
            //5. private Constructor


            //__________________1. Constructor__________________________
            #region constractor
            //1. constructor is Method with Same Class name
            //2. when we Make Object of Any Class ==> its ByDefault make ===> Blank Constructor
            //3. When We Run Applican   ===>Constructor ByDefault  Run ho gataa ===> or Subh kuch Display ho gata ha
            myConstractor cons = new myConstractor();

            //4. Constractor kuhc bhe    ---> Return nhin krtaa
            //---return hamsaa method he krtaa han ---> baarhaa 1khlaak wala hot han
            //---constractor to lalchi hota ha ====> bus  dalto rhaao data rho
            #endregion

            //__________________2. Non-Parameteriz &  Parametrize Constractor__________________________
            #region non-param & paramterize Constr
            //1. Non-paramterize Cons ==> me  Parameter nhin hotaa
            //2. Parameterize Constractor ==> me  Parameter hotaaa han
            //____non-paramter___
            yourConstractor con1 = new yourConstractor();

            //____paramter___
            yourConstractor con2 = new yourConstractor("Saqib");
            yourConstractor con3 = new yourConstractor("Saqib",25);

            //------- Its Basically Overloading Constractor Technice -------------
            #endregion

            //__________________2.1 overloading_Contractore __________________________
            //hum na  jo oper baar bar  bnyaa 1 name saa method =====> isaa Overloading khtaa
            //overloading agaa parhain ga

            //__________________3. Static Constractor __________________________
            #region static Constractor
            //1. Static Constractor   ===> Basic  Constractor saa   bhe ====> Phelaa Call hotaa ha
            //2. staic Constractor ===> Access Modifire nhin lgatta a ===> Yaa Chltaa he By Default ha
            //3. static Constractor ===> Paramter  nhn lgataa
            //4. static method (not accept)  ===> Parameter , return , access_modifire
            stConst stCon = new stConst();
            #endregion

            //__________________4. Copy Constractor __________________________
            //mujahaa Samjh nhin ayaa

            //__________________5. Private Constractor (Very Importent)__________________________
            //why?
            //1. Private_Constractor khud nhin Run hotaa ===> OverLoaded Contractor ko  Run krtaa ha
            //2. user saa Usa Parameter Lazmi Lana ka lyaa ---
            //3. Jab User Object bnyaa ===> to usaa ==> Force kraa ka  ===> Constractore kaa ===> Paremter day...
            privateConstrator abc = new privateConstrator("Saqib Ali");
            #endregion

            //___________________________________5. Static Class ________________________________
           
            //static Class is Same As  Static Method ===> if Class is Static ===> inside Every Thing is Static
            //1. Constractor will Not Work ===> its Completly Static


            //___________________________________6. Destruction Method________________________________
            //Destructive Metod ===> is used to  FreeUp space from ====> Memory ====> At the End of Program
            //its The Same  as Class Name
            //its only Has ---> Tildaa Symbol Before


        }
    }

}
