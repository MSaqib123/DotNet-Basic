using System;

namespace _4_Access_Modifire
{
    //__________ 1,2 public | private _________
    #region public && private
    class Parent
    {
        //____________Public______________ all project
        public void myFun()
        {
            Console.WriteLine("this is Public Method");
        }
        //____________private_______________ within this class only
        //by default private hotaa 
        private string name = "saqib";
        private void yourFun(string name)   //sir ya to byDefault hota --> lgayaa kyn =====> takaaa   dakhnaa waloo pataa chlaa
        {
            Console.WriteLine("this is private Method" + name);
        }
        public Parent()
        {
            yourFun(name);
        }
    }
    #endregion

    //__________ 3, protected _________
    #region protected
    class class1
    {
        protected void functionProtected()
        {
            Console.WriteLine("Protected Method (work on inhartance)");
        }

        public void show()
        {
            Console.WriteLine("public method");
        }
    }
    #endregion

    internal class Program : class1
    {
        static void Main(string[] args)
        {
            //_______________________________________________ 1. Access Modifires ________________________________________________
            //1. public                 ---> Can Access in All Projects  outSide the Project
            //2. private (by Default)   ---> only in Created Class (file)
            //3. protected              ---> Can Access in (Created/inharite) Classs
            //4. internal               ---> Can Access only Within The Project

            //_________________________ 1,2 (public, private)____________________________________
            #region public,private
            //___ 1.Public ___
            Parent p = new Parent();
            p.myFun();

            //___ 2.Private ___
            //p.     //not Accessbull  private
            #endregion

            //_________________________ 3 protected____________________________________
            #region
            class1 c = new class1();
            c.show();
            //after inharitance
            Program p1 = new Program();
            p1.show();
            p1.functionProtected();
            #endregion

            //_________________________ 4 internal____________________________________
            //in this whole project ===> not other project
        }
    }
}
