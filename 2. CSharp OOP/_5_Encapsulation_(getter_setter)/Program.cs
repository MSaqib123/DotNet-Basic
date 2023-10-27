using System;

namespace _5_Encapsulation__getter_setter_
{

    //_______________________ 1. Simple Incapsulation _________________________
    #region Simple_Incapsulation
    public class Parent
    {
        //-------- private ----
        //how can i access in other classs ===> getter setter
        private string username;
        private string password;
        private int accountBalance;

        //-------- getter setter ------
        //getter -> get the value
        //setter -> set the value to variable

        //___ UserName ____
        public void setusername(string username) //user saa paramter laa ker
        {
            if (string.IsNullOrEmpty(username) == true)
            {
                Console.WriteLine("Empty value not Allowed");
            }
            else
            {
                this.username = username; //private var ==> me Set kr dyaa  (setter)
            }
        }
        public void getusername()
        {
            Console.WriteLine("Your Name : " + this.username);
        }

        //___ Password ____
        public void setuserpassword(string password)
        {
            //___ Password ____
            if (string.IsNullOrEmpty(password) == null)
            {
                Console.WriteLine("Password is Empty");
            }
            else
            {
                this.password = password;
            }
        }
        public void getuserpassword()
        {
            Console.WriteLine("Your Password : " + this.password);
        }

        //___ Account balance ____
        public void setuseraccountbalance(int accountBalance)
        {
            //___ accountBalance ____
            if (accountBalance < 0)
            {
                Console.WriteLine("Invalid Balance");
            }
            else
            {
                this.accountBalance = accountBalance;
            }
        }
        public void getuseraccountbalance()
        {
            Console.WriteLine("Your account Balance : " + this.accountBalance);
        }
    }

    #endregion



    //_______________________ 2. Incapsulation by (get,set) Properteis _________________________
    #region get,Set 
    class Parent1
    {
        private string name;
        private int age;

        //___ Encapsulation ___
        public string _name
        {
            //1. set
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    name = value; //value which given by user
                }
            }
            //2. get
            get
            {
                return name;  //return   value which given by user
            }

        }
        public int _age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                }
            }
            get
            {
                return age;
            }
        }

    }
    #endregion

    //_______________________ 3. Types of Encapsoultin _________________________
    //______ 2. Read only ______
    #region readOnly
    //means   only  Getting Value  (value is ByDefault Set)
    class read1
    {
        private string name= "Farhan";
        public string _name
        {
            //set
            //{
            //    name = value;
            //}
            get
            {
                return name;
            }
        }
    }

    #endregion

    //______ 3. write only ______
    #region writeOnly
    //means   only  Getting Value  (value is ByDefault Set)
    class write1
    {
        private string name;
        public string _name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
    #endregion

    //______ 4. Auto Implemented ______
    #region auto Implement
    class autoPrope {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
    #endregion

    //______ 5. Static Incapsulation (get,setpro) ______
    #region Static_Incapsulation
    class staticProperteis
    {
        public static int Id { get; set; }
        public static string name { get; set; }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Inhartance
            //2. Incapsulation
            //_______________________________________________ 1. Incapsulation ________________________________________________
            #region Encapsulation
            //to protect Data from user 
            //to hide Extra information from user
            //Exemple :-  Bank me  Bill Submit krwata ha ===> to humain sa sirf ====> Raqam le gati ha  \ ya nhin btataa kaa --> is me text kittna

            //________________ 1. Simple Incapsulation ____________________
            #region Simple_Incapsulation
            Parent p = new Parent();
            p.setusername("Saqib");
            p.getusername();

            p.setuserpassword("s12345");
            p.getuserpassword();

            p.setuseraccountbalance(-3);
            p.getuseraccountbalance();

            #endregion


            //________________ 2. Incapsulation by (set,get) Properteis ____________________
            #region set,get Properteis
            // same as uper work
            Parent1 p1 = new Parent1();

            p1._name = "Farhan Sir";
            Console.WriteLine("\nName : "+ p1._name);

            p1._age = 30;
            Console.WriteLine("Age : " + p1._age);
            #endregion
            #endregion

            //_______________________________________________ 2. type of Encapsulation ____________________________
            #region Types of Encapsulation
            //1. Read / Write Prop
            //2. Read only
            //3. Write only
            //4. auto implemented props
            //5. static props

            //_______________________ 1. Read / Write ____________________
            //set , get Value both --->Uper Work

            //_______________________ 2. Read only ____________________
            #region read_Only
            //we can not Set value ===> it by default Seted
            read1 r1 = new read1();
            //r1._name = "Saqib";
            Console.WriteLine("Name : " + r1._name);
            #endregion
            //_______________________ 3. Write only ____________________
            //we can not get Value ====> only Set Value allowed

            //_______________________ 4. Auto Implemented Properteis ____________________
            autoPrope auto = new autoPrope();
            auto.id = 1;
            auto.name = "Saqib";
            auto.age = 35;
            Console.WriteLine("\nId : " + auto.id);
            Console.WriteLine("Name : " + auto.name);
            Console.WriteLine("age : " + auto.age);

            //_______________________ 5. Static Encapsulation ____________________
            //static  (Prop)  directly   accessble by   the   Name of Class
            staticProperteis.Id = 12;
            staticProperteis.name = "farhan";

            Console.WriteLine("Id : " + staticProperteis.Id);
            Console.WriteLine("Name : " + staticProperteis.name);
            
            #endregion

           

        }
    }
}
