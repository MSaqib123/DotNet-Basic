using System;
using System.Collections.Generic;

namespace _8_DI
{
    //_____________________________________________ 1. (DI) Dependency Injection ___________________________________________________
    #region DI
    /*-_________________ 1. Tight Coupling _________________________*/
    #region Tight_Coupling
    class Student
    {
        StudentDetail d = new StudentDetail();
        public void Show()
        {
            d.getName();
        }
    }
    //studen Class --> heighly  Depend on StudentDetail Class ===> if  StudentDetail Calss ==> Deleted ===> Student Class is Useless
    interface detail
    {
        void getName();
    }
    class StudentDetail:detail
    {
        public void getName()
        {
            Console.WriteLine("Sahazad");
            Console.WriteLine("Billal");
            Console.WriteLine("akram");
            Console.WriteLine("Nian");
            Console.WriteLine("Sahazad");
            Console.WriteLine("Billal");
        }
    }
    #endregion

    /*-_________________ 2. Making Loose Coupling _________________________*/
    #region Making_loose Couple
    class injectorClass
    {
        detail1 _detail1;
        public injectorClass(detail1 detail)
        {
            this._detail1 = detail;
            this._detail1.getName();
        }
    }

    class Student1
    {
        //____________ Directly Depend on StudentDetail Class __________________
        //StudentDetail d = new StudentDetail();
        //public void Show()
        //{
        //    d.getName();
        //}

        //____________ Now Depend On Injector __________________
        injectorClass Iinjector = new injectorClass(new StudentDetail1());
    }

    //studen Class --> heighly  Depend on StudentDetail Class ===> if  StudentDetail Calss ==> Deleted ===> Student Class is Useless
    interface detail1
    {
        void getName();
    }
    class StudentDetail1 : detail1
    {
        public void getName()
        {
            Console.WriteLine("Sahazad");
            Console.WriteLine("Billal");
            Console.WriteLine("akram");
            Console.WriteLine("Nian");
            Console.WriteLine("Sahazad");
            Console.WriteLine("Billal");
        }
    }
    #endregion


    /*-_________________ 3. loose Coupling _________________________*/
    #region Loose Coupling
    //1. Client Class               = >  is a class which  Depend on Services (studnet,teacher,lab,peons,.....)
    //2. Service class  = >  is a class  which provide  Services to     Client Class 
    //3. Injector                   = >  is a object which  Inject  The Services(interface) into  Client Class


    //2. client class    depend on Servics (teacher,student)
    public class BusnissLogicServices
    {
        private IService iService;
        public BusnissLogicServices(IService _iService) //main class sa ay ge
        {
            this.iService = _iService; //initalize Value in    this.iServices   ===> Which Comes from Ijector

            this.iService.getFirstName();
            this.iService.getlastName();
        }
    }

    public interface IService
    {
        void getFirstName();
        void getlastName();
    }


    //1. service class
    public class StudentService : IService
    {
        public void getFirstName()
        {
            Console.WriteLine("Student 1st Name");
        }
        public void getlastName()
        {
            Console.WriteLine("Studnet last Name");
        }
    }
    public class TeacherService : IService
    {
        public void getFirstName()
        {
            Console.WriteLine("Teacher 1st Name");
        }
        public void getlastName()
        {
            Console.WriteLine("Teacher last Name");
        }
    }
    #endregion
    #endregion

    //_____________________________________________ 2. Types of DI _________________________________________________--
    //______1 Constractor________
    #region 1. Construction_Inject
    public interface text
    {
        void print();
    }

    public class formate : text   //injection is ko lgaa gaa ==> is ko  loosly Couple krnaa ha
    {
        public void print()
        {
            Console.WriteLine("This is TExt Formate");
        }
    }

    public class constructorInjection
    {
        private text _text;

        public constructorInjection(text text)
        {
            this._text = text;

            //__ Calling the print Function ___
            
        }

        public void show()
        {
            _text.print();
        }
    }
    #endregion

    #region 1. Construction_Inject
    //_______________________ Tight Coupling _________________________
    public class Students
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
    }
    //_______ 2. to solve Issue ______
    public interface IStudentDataAccessLayer
    {
        List<Students> GetStudents();
    }

    //adding Data
    //_______ 3. implement ______
    public class StudentDataAccessLayer: IStudentDataAccessLayer
    {
        public List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { id = 1, Name = "Student 1", Standard = "12th" });
            students.Add(new Students() { id = 2, Name = "Student 2", Standard = "11th" });
            students.Add(new Students() { id = 3, Name = "Student 3", Standard = "10th" });
            return students;
        }
    }
    //retrieving Data
    public class StudentBuisnessLayer
    {
        //_____________ 1. Issue  this Class Depended on StudentDataAccessLayer ______________
        //in Future if we Move          GetStudent()  Method  in  other Class
        //then we have to Change  ==>  StudentBuisnessLayer
        //________ know We have to add iInjector    constractor Inject __________
        //public List<Students> GetStudent()
        //{
        //    StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
        //    return studentDataAccessLayer.GetStudents();
        //}

        //________________ 4. Constructor di__________________________
        private IStudentDataAccessLayer studentDataAccessLayer;
        public StudentBuisnessLayer(IStudentDataAccessLayer studentDataAccessLayer)
        {
            this.studentDataAccessLayer = studentDataAccessLayer;
        }

        public List<Students> GetStudents()
        {
            return studentDataAccessLayer.GetStudents();
        }
    }

    #endregion


    //______2 Property________
    #region Propertie_Injection_1
    public interface iLogger
    {
        void userName();
    }

    public class user : iLogger
    {
        public void userName()
        {
            Console.WriteLine("User of websites");
        }
    }

    public class admin : iLogger
    {
        public void userName()
        {
            Console.WriteLine("admin of websites");
        }
    }

    public class propertyInject
    {
        iLogger _logger = null;

        public void notify(iLogger logger)
        {
            //__ Properties __
            this._logger = logger;
            this._logger.userName();
        }
    }
    #endregion

    #region Propertie_Inject_2
    public class Student1s
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
    }

    //__________ 2. to solve Issue ______
    public interface IStudent1DataAccessLayer
    {
        List<Student1s> GetStudents();
    }

    //Adding Data
    //__________ 3. implement __________
    public class Student1DataAccessLayer : IStudent1DataAccessLayer
    {
        public List<Student1s> GetStudents()
        {
            List<Student1s> students = new List<Student1s>();
            students.Add(new Student1s() { id = 1, Name = "Student 1", Standard = "12th" });
            students.Add(new Student1s() { id = 2, Name = "Student 2", Standard = "11th" });
            students.Add(new Student1s() { id = 3, Name = "Student 3", Standard = "10th" });
            return students;
        }
    }

    //retrieving Data
    public class Student1BuisnessLayer
    {
        //_____________ 1. Issue  this Class Depended on StudentDataAccessLayer ______________
        //in Future if we Move          GetStudent()  Method  in  other Class
        //then we have to Change  ==>  StudentBuisnessLayer
        //________ know We have to add iInjector    constractor Inject __________
        //public List<Students> GetStudent()
        //{
        //    StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
        //    return studentDataAccessLayer.GetStudents();
        //}

        private IStudent1DataAccessLayer student1DataAccessLayer;

        //________________ 4. Constructor di__________________________
        //public StudentBuisnessLayer(IStudentDataAccessLayer studentDataAccessLayer)
        //{
        //    this.studentDataAccessLayer = studentDataAccessLayer;
        //}

        //________________ 5. Property di__________________________
        public IStudent1DataAccessLayer studentData
        {
            set
            {
                student1DataAccessLayer = value;
            }
            get
            {
                if (student1DataAccessLayer == null)
                    throw new Exception("Object Not passed to the property");
                else
                    return student1DataAccessLayer;
            }
        }
        public List<Student1s> GetStudents()
        {
            return student1DataAccessLayer.GetStudents();
        }
    }

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            //_________________________________________ 1. (DI) Dependency Injection ___________________________________________________
            #region DI
            //1. Tight Coupl        Classes are  Highly Depended on One another                             Not Good for Software
            //2. Loose Coupl        Classes are  Depend on  iInjector   ==> but  Not Each Other <===        Very Good for Software

            //______ DI ______
            //1. its Software design  ==> pattern ==> enable   ==> loosly Couple
            //2. its  Reduce  ===> tight Coupling  
            //3. it make ==> code more  ==> manageable


            //_______________________ 1. Tight Coupl ________________________
            #region Tight_Couple
            Student st_tight = new Student();
            st_tight.Show();
            #endregion

            //_______________________ 2. Making Loosly Couple  ________________________
            #region loosly_Couple

            Student1 st = new Student1();
            #endregion


            //_______________________ 3. loose Coupl _____________________
            #region MyRegion
            //BusnissLogicServices studnetInject = new BusnissLogicServices(new StudentService());
            //BusnissLogicServices teacherInject = new BusnissLogicServices(new TeacherService());
            #endregion

            #endregion

            //_________________________________________ 2. Types of DI  ___________________________________________________
            //1. Constructor Injection 
            //2. Property Injection
            //3. Method Injection

            //______________________ 1. Constructor Injection  ________________________
            #region 1. Constractor DI
            //its has  only  1 Parametrize Constructor Injection
            //is me hum  1 Time me 1  he Injection kr Sktaa han
            constructorInjection iInjector = new constructorInjection(new formate());
            iInjector.show();
            //ab  formate class   directly  Interface par   Depended nhin haa ====>   iInjector  ka   Kam ha ka Wo  ===> Interface Sa value laa kr ay
            #endregion

            #region 1. Constractor DI
            StudentBuisnessLayer studentBuisnessLayer = new StudentBuisnessLayer(new StudentDataAccessLayer());
            var result = studentBuisnessLayer.GetStudents();
            #endregion


            //______________________ 2. Property Injection  ________________________
            #region 2. Property Injection
            propertyInject Iinjector = new propertyInject();
            Iinjector.notify(new admin()); //now The Admin is Directly Depend on Injectore
            Iinjector.notify(new user()); //now The User is Directly Depend on  Injectore

            //______ itnaa krni ki kya zroorat the -------
            //is tarhaa sa bhee Kr sktaa thaa
            admin a = new admin();
            a.userName();
            #endregion

            #region 2. Property Injection
            //____ constractor Di ____
            //StudentBuisnessLayer student1BuisnessLayer = new Student1BuisnessLayer(new Student1DataAccessLayer());
            //____ Property Di ___
            Student1BuisnessLayer student1BuisnessLayer = new Student1BuisnessLayer();
            student1BuisnessLayer.studentData= new Student1DataAccessLayer(); 
            var result1 = studentBuisnessLayer.GetStudents();
            #endregion

            //______________________ 3. Method Injection  ________________________
            //1. its Very Just Remove  Property 
            //2. Add  student1DataAccessLayer    ==> in GetStudents()   Method  as Praemter
            //3.  GetStudent(student1DataAccessLayer) {}

            //go to This Lecture and What
            //https://www.youtube.com/playlist?list=PLQVCSt-IuOa1xDA_-RomKAkTuWYlA398t
        }
    }

}
