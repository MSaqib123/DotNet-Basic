using System;

namespace _6_Polymorephism
{

    //____________________ 1. Static Binding (OverLoading) _____________________
    #region static_Binding
    //overloading  (loading ka wqat  CompileTime)
    class staticBinding
    {
        public void sum()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("sum is : " + c);
        }
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum is : " + c);
        }
        public void sum(float a , float b)
        {
            float c = a + b;
            Console.WriteLine("sum is : " + c);
        }
    }
    #endregion

    //____________________ 2. Dynamtic Binding (OverRinding) _____________________
    #region Dynamic_Binding_1
    class Parent
    {
        public void Message()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    class Child/*drived child class*/ : Parent//base Perent class 
    {
        public new void Message()  //new ==> indecate That ===> its Child Constractor
        {
            base.Message();  //child Parent ko  ==> targeh  daa gaa ==> App pehlaa Run hon 
            Console.WriteLine("This is Child Message");
        }
    }
    #endregion

    //____________________ 2.1 Dynamic Binding  OverRinding (virtual , override) _____________________
    #region Dynamic_Binding_2
    class Parent1
    {
        //___________ 1 Virtual Method __________
        public virtual void Message()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    class Child1 : Parent1
    {
        //___________ 2 overrride Method __________
        public override void Message()
        {
            Console.WriteLine("This is Child Message");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Inharitance
            //2. Incapsulation
            //3. PolymorePhism
            //________________________________________________________ Polymorephism _________________________________________________________
            //1. Static Binding (OverLoading method ore Propertes)
            //2. dynamic Binding (Over Riding Methods)
            //3. Method Hiding

            //________________________ 1. Static Binding ______________________________
            #region 1. Static Binding (Over_Loading)
            //1. jub hum ====>  Same (NAME) methods ko ====> paremters,signatures ====> saa ====> Overload krtaa han
            //2. its Compilte Time Proccess (when we typing)
            staticBinding st = new staticBinding();
            //3. if Signatures Match with  Method ==> That Method will Executed
            //st.sum();//1st executed 
            //st.sum(2,8); //overload ===> ho gy  1st par
            st.sum(2f, 8f);   //postes  (overload) ===> 2nd par

            #endregion

            //________________________ 2. Dynamic Binding (OverRiding) ______________________________
            #region 2. Dynmaic Binding (OverRiding)
            //1. OverRiding ==> is RunTime Process   (When Program is Runing)
            //2. OverRiding ===> Classes ke  Between hoti ha
            //2. OverRiding ===> Work With =====> Inharitance     ,,,, <<<<    WithOut Inharitance   Dosn't work
            //3. kyun?

            //__Before__
            Child child = new Child();
            child.Message();// 1. Child wil run ===> 

            //___After adding base in child Contractor___
            //base.message();
            #endregion

            //________________________ 2.1 OverRinding Methods (virtual , override) _____________________
            #region 2.1 Virtual_override
            //==> if we don't want make new Function ===> Wanan  use   Parent Class FN in Child so  ==-> use Virtual , Override
            //=> this work ==> on Inharitance
            //1. Virtual (Behavires) ==>  ko  Override kr sktaa han ==> hum   ==> Inharit Classes me
            //2. 1 Name ka FN ===> humara Baar Baar use hotaa rhaa ga

            Child1 c1 = new Child1();
            c1.Message();
            #endregion
            
        }
    }
}
