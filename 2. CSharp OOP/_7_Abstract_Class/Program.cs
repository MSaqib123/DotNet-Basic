using System;

namespace _7_Abstract_Class
{
    //_____________________ Abstraction Exemple Why ?_________________________
    #region Exemple
    class employee
    {
        public int gross_salary; //Bonus Salary --> Overtime Sallary
        public int net_salary;

        //____________ This To Hid _________
        //__constractor__
        public employee(int gross_salary)
        {
            this.gross_salary = gross_salary;
            //--
            calculate_Salary(this.gross_salary);
        }
        //calculate
        public void calculate_Salary(int gross_salary)
        {
            int value = gross_salary + 1200;//pertrol
            value = value - 340; //tex
            this.net_salary = value;
        }


        //____________This To Show________________ User
        public void show()
        {
            Console.WriteLine("Your Net Salary : " + this.net_salary);
        }
    }
    #endregion


    //_____________________________ 1. Abstraction by Class_______________________________________
    #region Abstraction by Class

    //____ Abstraction on Method  + (Multi_Level) + Abstraction on Props ____
    #region 1_Abstraction Simple
    //abstract class
    abstract class person
    {
        //__ abstract Method __
        abstract public void show();  //{}  body  ===> Implement par bna ge

        //__ normal Method __ 
        public void normal()
        {
            Console.WriteLine("this is Nomal Method");
        }
    }
    //conkert Class (noram)
    class customer : person
    {
        //_______ Implemented Method ===> Override hotaa ha Hamasahaaa____
        //polymorphism
        public override void show()
        {
            Console.WriteLine("this is Abstract Method ===>  in  Customer Class");
        }
    }
    #endregion

    #region 2_Abstraction_Multi_Level
    abstract class grandFather
    {
        abstract public void Show1();
    }

    abstract class father : grandFather
    {
        //void
        abstract public void Show2();
        //string
        abstract public string Show3();
    }

    class child : father
    {
        override public void Show1()
        {
            Console.WriteLine("Paksitan zindiba");
        }
        override public void Show2()
        {
            Console.WriteLine("India Lost cricket match");
        }

        //___ string abstracte method ___
        override public string Show3()
        {
            return "Pakistan";
        }
    }
    #endregion

    #region 3_Abstraction_On_Props
    //3 topic are in This   Logic
    abstract class abstractionProps
    {
        //________ 1 abstract Prop _________
        abstract public string Name { get; set; }
    }

    class inharitAbstractClass : abstractionProps
    {
        //________ 3 Incapsulation __________
        private string _Name;

        //________ 2 Implement __________
        //access yaa ho gaa  on  Instance of Object
        public override string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }

    }
    #endregion

    //____ Multiple inhartiance by Abstact_class _____              (1 child ==> 2 Father nhin) bnaa sktaa
    //2. not Suported by abstraction_class
    //1. not suported by concrent_Class
    #region Multiple_Abstraction
    //abstract class class1
    //{

    //}

    //abstract class class2
    //{

    //}

    //abstract class class3
    //{

    //}

    //_____ Error on Multiple inhartiance  by Abstract Class _____
    //class myClass: class1,class2,class3
    //{

    //}
    //#endregion

    #endregion

    #endregion

    //_____________________________ 2. Abstraction by Interface _______________________________________
    #region Abstraction by Interface

    //_____ Basice Interface _____
    #region Simple_Inteface
    interface IEmployee
    {
        //___ 1  Simple ____
        void show();

        //___ 2 Parametrize ____
        void show1(string name);


        //___ 3 overloadded ____
        void show1(string fNamme , string lName);

        //___ 4 different Signature ____
        void show1(string name , int age);

        //___ 5 Return ____
        string Pakistan();
    }

    class interfaceClass : IEmployee
    {
        //____ 1 Simple ___
        public void show()
        {
            Console.WriteLine("1) Interface Show()  ===>  Simple");
        }

        //____ 2 parameterize ___
        public void show1(string userName)
        {
            Console.WriteLine("2) Inteface show1()  ==> Name : " + userName);
        }

        //_____ 3 overloaded ______
        public void show1(string f , string l)
        {
            Console.WriteLine("3) Inteface show1()  ==> fullName : " + f + " " + l);
        }

        //_____ 4 different Signature _____
        public void show1(string name, int age)
        {
            Console.WriteLine("4) Inteface show1()  ==> Name : " + name + " ++ Age : " + age );
        }

        //_____ 5. Return InterFace _____
        public string Pakistan()
        {
            return "Pakistan Zinda bad";
        }
    }
    #endregion

    //_____ Multi_Level Interface  Inharitance _____
    #region Multi_Level_Interface
    interface interface1
    {
        void show1();
    }

    interface interface2 : interface1
    {
        void show2();
    }

    //__ Inharitance __
    class child1_Inteface : interface2
    {
        public void show1()
        {
            Console.WriteLine("Show1 is  __ Inteface_1");
        }
        public void show2()
        {
            Console.WriteLine("Show 2 is  __ Inteface_2");
        }
    }

    #endregion

    //_____ Multiple Interface Inharitance _____
    #region Multiple_Inharitance

    
    interface i1
    {
        void password1();
    }

    interface i2
    {
        void password2();
    }

    interface i3
    {
        void password3();
    }
    
    //_____ Admin 1 ________
    class Admin1 : i1, i2, i3
    {
        public void password1()
        {
            Console.WriteLine("saqib12345");
        }
        public void password2()
        {
            Console.WriteLine("Boota12345");
        }
        public void password3()
        {
            Console.WriteLine("RashidAli_12345.12345");
        }
    }

    //_____ Admin 2 ________
    class Admin2 : i1, i2, i3
    {
        public void password1()
        {
            Console.WriteLine("saqib12345");
        }
        public void password2()
        {
            Console.WriteLine("Boota12345");
        }
        public void password3()
        {
            Console.WriteLine("RashidAli_12345.12345");
        }
    }

    #endregion

    //_____ Multiple Interface Inharitance _____
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            /*________________________________________ Abstract Class (Method,Properties) _________________________________________________*/
            //1. Inharitance
            //2. Encapsulation
            //3. Polymorephism
            //4. Abstraction

            //_____________________ Abstraction Exemple _________________________
            #region Exemple
            //why?   to Hide  Unnessory information ===> From User
            //Exp:   TV remote ===>  Compney ===> Instraction dati ha ===> (kassaa Use use ho ga) ==>     (yaa nhin bta ti  kasaa banaa gaa)

            employee empNetSalleryCalculatro = new employee(3200);

            //___Net Salary After  Tex Adding and Pertorl Adding__
            empNetSalleryCalculatro.show();

            //_____ User kyaa Daa ga ===> Value (3200)
            //_____ or Net Salary Mil Gay ge ===>  
            //_______ Us ko nhin ptaa kaaa  kitna  (Tex) tha   ==> Kitna (pertrol price) thaa ____


            //______________ This is Call Abstraction ___________________
            //hum Main  Code  Hide krtaa han ====>   user ko Sirf  ==> rquired Method show krtaa han
            #endregion

            /*____________________________________________________ Abstraction __________________________________________________________*/
            #region
            /*
            Inharitance  ===>  for Similar Propertes,Behaviers
            Abstraction  ===>  for Different Prop , Behaviors     

            Types of Abstraction
            ___1. Abstraction by Class _____
            ___2. Abstraction by Interface ____

            1. Normal Class    --->    conkeret Class                         (abstract class nhin hoti)
            2. abstract class  --->    abstract Class
            3. Ager koi Abstract Method Class me Bnain ga     ---->           Class ko  Lazman Abstract krna paraa ga
            4. Abstract Class  Normal                         ---->           (Method,Instance Object)   bhe bnaa sktaa han
            */
            #endregion

            //____________________________________________________ 1 Abstraction by Class __________________________________________________________
            #region Abstraction by Class

            //____________________ Abstraction on Method  + Multip_level  + on Props_______________________
            //abstract method hamsaasaa    abstracte Class me he bntaa ha
            #region 1_Abstraction_on_Method
            //1. Abstract Methods ==>  Body {} nhin hoti
            //2. abstract method  ==>  abstracte public void xyz();
            //3. abstract method  ==>  Hamashaa Hamashaa   (Internal,Public) hotaaa       Private nhin ho sktaa

            //____ 4. abstract method  ==> Implement on Inharite Class ___
            //____ 5. Abstract Class   ==> ka  Instante Object kabhi nhin bntaaa ____  (Inharit Class ka object bntaa h)

            //person p = new person();     abstract class
            customer cut = new customer();
            cut.show();
            cut.normal();

            customer cu = new customer();
            cu.show();
            cu.normal();

            //How to Get normal Method for abstraction Class ?????
            person pa = new customer();
            pa.normal();
            pa.show();

            #endregion

            #region 2_Abstraction Multi_Level
            //grandFather grandFather = new grandFather();          Abstracte
            //grandFather.Show1();

            //father f = new father();    Abstracte
            //f.Show1();
            //f.Show2();
            //f.Show3();
            child c = new child();
            c.Show1();
            c.Show2();
            string s = c.Show3();
            Console.WriteLine("Abstracte Return : "+ c.Show3());

            #endregion

            #region 3_Abstraction_on_Props (set,get properteis)
            //1. abstract Prop
            //2. implement/inarite  prop
            //3. Encapsulation
            //---- jo kam hum ===> Incapsulation me krtaa ha  ====> Same Work  ha ====>  but  ===> ab hamari    Double Security ha
            //---- Prop ==> Abstract ha + (Implement + Private Main Variable) 
            //---- User   ==> abstract Prop (jo Implement )  ==> use kraa ga ==> This is also 
            inharitAbstractClass implement = new inharitAbstractClass();
            implement.Name = "Pakistan Pak"; //set   
            Console.WriteLine("\n\nAbstract Prop : " + implement.Name +"\n"); //get
            #endregion

            //____________________ Multiple Absraction _______________________  1 child ka  2 baap
            //not supported
            //1. inharitance ==> not supported by  ===>  concernt_Class
            //2. inharitnce ===> not supported by ===> abstracte_Calss

            //==============
            //_____ Intraface is Allowed ==> Multiple inharitance ____
            //==============
            #endregion


            //____________________________________________________ 2 Abstraction by Interface __________________________________________________________
            #region Abstraction by Interface
            //1. For   Multiple Inaritance
            //2. It  Decrease (Thousound Lines of Code) into   ==> Half_lines
            //3. Increase The Security Level
            //4. Make Easy ===> Modification     (1 intrface me Change krtaa han) ===> har tarf change apply ho gata ha
            //---> hari jitni bhee Repetead Action ===> Works ===>   Intrface sa hum ===>   baar use kr lata han ===> baar baar likhaa  ke bjaay
            //Exp.  Insert, Delete, update, View ---> Search ........


            //_________________________ 1 Basic Interface ________________________
            #region 1. Basice_of_Intrface
            //_______ Note _____
            //1. interface only  ---> Accept  Method 
            //2. interface Method are   by_Default    ===>    public,Abstract             (Interface Abstraction) me ===>  ovverride , pubic  by default hotaa han
            //3. on Implemtation ===> By_Default  ===> Override     hotaa han

            //1. Parameterize Method
            //2. overloaded Method
            //3. different Signature Method

            //1. return Type Method

            interfaceClass i = new interfaceClass();
            i.show();
            i.show1("Saqib1234");
            i.show1("Muhammad","Saqib");
            i.show1("Muhammad Saqib", 25);
            Console.WriteLine(   i.Pakistan() );

            #endregion

            //_________________________ 2 Multi_Level Interface  Inharitance ___________________
            //same as Multi_level inharitance    
            // Multilevel  1 inteface  2nd interface ka   Data   Daakh rhaa han   / Rakh rhaaa ha
            #region 2. Multi_Level_Interface

            #endregion

            //_________________________ 3 Multiple Interface  Inharitance __________________
            //to Securte Data form  --> other Interfaces
            #region 3. Multiple_Inharitace
            //_______ Why? _______
            //1. 1 child ===> 2,3,4..  baap bnanaaa ka lya hum =====>  multiple inharitance (inteface)

            //_______ ? ________
            //sir yaa kaam  to ===> multi_level inharitance saa bhee ho sktaa ha
            //-- so Why? --

            /*let:
                i have  3 interfaces  ===> or  ====> 3no interace ka Data  ==> Secure    
                --> means   ---> 1 interface 2nd Intrface ka  ==> data nhin daakh sktaa
                -------------- laakeen ------------------
                hum ==> on 3no  Interface ka data ====>  kisi Class me ====>>   Use krnaa Chtaaa han

                ------> ^^^^^ To hum  (Multiple) inhritance    by  Intefacess ^^^^^^ <--------
                
                XXXXX=>  ya Multi_level me =====>   asaa nhin hotaa
            */

            //Exemple :_-    1 user  2nd user kaa  Data nhin daakh skta     =====> mgar   admin  ===>  Saraaa  Users ka  Data  Daakh skaaaa


            #endregion


            #endregion

        }
    }
}
