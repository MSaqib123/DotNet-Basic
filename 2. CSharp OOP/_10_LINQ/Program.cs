using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_LINQ
{
    public class emplyees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary{ get; set; }
        public string department { get; set; }
        public int Age { get; set; }

    }

    //___ for join ____
    //new Person { empId = 1, productQuentity = 5, Amount = 30 },
    public class employee_Orders
    {
        public int empId { get; set; }
        public int productQuantity { get; set; }
        public int Amount { get; set; }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            goto practice;

        //_____________________________________ LINQ (Language-Integrated-Query) ___________________
        //smilar like  SQL (Query)

        //_________ Dafination ___________
        //(Language-Integrated Query) is a set of features in C# and .NET that provides a uniform way to query data
        //from different sources,
        //such as arrays, lists, databases, and XML documents.

        //_________ Methods List ____________
        //LINQ provide set of Method    to  Filter Data, SElect Data ........
        #region All_Methods
        /*
         Filtering Operators:
            Where
            OfType

         Projection Operators:
            Select
            SelectMany

        Sorting Operators:
            OrderBy
            OrderByDescending
            ThenBy
            ThenByDescending
            Reverse

        Grouping Operators:
            GroupBy
            ToLookup

        Set Operators:
            Distinct
            Union
            Intersect
            Except

        Join Operators:
            Join
            GroupJoin

        Partitioning Operators:
            Take
            TakeWhile
            Skip
            SkipWhile

        Aggregation Operators:
            Count
            LongCount
            Sum
            Average
            Max
            Min
            Aggregate
            GroupBy
            Join
            GroupJoin

        Conversion Operators:
            ToArray
            ToList
            ToDictionary
            ToLookup
            Cast
            AsEnumerable

        Element Operators:
            First
            FirstOrDefault
            Last
            LastOrDefault
            Single
            SingleOrDefault
            ElementAt
            ElementAtOrDefault
            DefaultIfEmpty

        Generation Operators:
            Range
            Repeat
            Empty

        Equality Operators:
            SequenceEqual

        Combination Operators:
            Concat
            Zip
         */
        #endregion


        //============================================================
        //___ 1. over All Class Data use krn ga
        //___ 2. Importent importent Method
        //============================================================
        List<emplyees> p = new List<emplyees>
            {
                new emplyees { Id=1 ,Name = "Alice", Age = 25 , salary=50000,department="HR"},
                new emplyees { Id=2 ,Name = "Bob", Age = 30 , salary=5000,department="IT"},
                new emplyees { Id=3 ,Name = "Charlie", Age = 35, salary=22000,department="Bus" },
                new emplyees { Id=4 ,Name = "Sajid", Age = 35, salary=33000,department="Admin" },
                new emplyees { Id=5 ,Name = "Noman", Age = 35, salary=1000,department="Peon" },
                new emplyees { Id=6 ,Name = "Akram", Age = 35, salary=20000,department="Peon" },
                new emplyees { Id=7 ,Name = "Amaar", Age = 35, salary=50000,department="Peon" },
                new emplyees { Id=8 ,Name = "Ali", Age = 35, salary=1000000,department="HR" },
                new emplyees { Id=9 ,Name = "Bob", Age = 30 , salary=9990000,department="IT"},
                new emplyees { Id=10 ,Name = "Bakeer", Age = 30 , salary=999000,department="IT"},
                new emplyees { Id=11 ,Name = "Basheer", Age = 22 , salary=99900,department="IT"},
                new emplyees { Id=12 ,Name = "Muneeer", Age = 23 , salary=10000,department="IT"},
                new emplyees { Id=13 ,Name = "Zehshaan", Age = 25 , salary=1000,department="IT"},
            };



            //______________________ 1. Filtering ( Select,Where )  Linque __________________
            #region 1. Filter
            //_______________________ 1. Select _______________ to Select Column
            //___ 1. Single Column Select ___
            Console.WriteLine("\n=================== 1. Select =====================");
            var people1 = p.Select(x => x.Name);
            foreach (var item in people1)
            {
                Console.WriteLine("SingleColumn : " + item);
            }
            //___ 2. Multiple Column Select ___
            var people2 = p.Select(x => new { x.Name, x.department, x.salary, x.Age });
            foreach (var item in people2)
            {
                //_________ Id --> Error ______________  Linq me  Select he nhin
                //Console.WriteLine(item.Id + " " + item.Name + ' ' + item.department + ' ' + item.salary + ' ' + item.Age);
                Console.WriteLine("MultipleColumn : " + item.Name + ' ' + item.department + ' ' + item.salary + ' ' + item.Age);
            }


            //_______________________ 2. Where _______________
            Console.WriteLine("\n=================== 2. Where + Select =====================");
            var people3 = p.Where(x=>x.department=="IT" && x.Age >= 25).Select(x=> new {x.Name,x.department , x.salary, x.Age});
            //select without  Where bhee   Work kraa gaa
            foreach (var item in people3)
            {
                Console.WriteLine(item.Name + ' ' + item.department + ' ' + item.salary +' '+ item.Age);
            }

            //_______________________ 3. OffType _______________
            //bakwaas haa  Not Used Much

            #endregion

            
            //______________________ 2. Sorting  Linque __________________
            #region 2. Sorting
            //____ 1. order by Ascending ___s
            Console.WriteLine("\n====================Order by Ascending (department) ================");
            var p1 = p.OrderBy(x=>x.department);
            foreach (var item in p1)
            {
                Console.WriteLine(item.Name + ' ' + item.department + ' ' + item.salary + ' ' + item.Age);
            }

            Console.WriteLine("\n====================Order by Descending (department) ================");
            p1 = p.OrderByDescending(x => x.department);
            foreach (var item in p1)
            {
                Console.WriteLine(item.Name + ' ' + item.department + ' ' + item.salary + ' ' + item.Age);
            }


            #endregion


            //______________________ 4. Aggregate Linque __________________
            #region 3. Aggregate
            Console.WriteLine("\n===== Sum ===========");
            var val = p.Sum(x=>x.salary);
            Console.WriteLine("Sum of All salery  : "+ val);

            Console.WriteLine("\n===== Max ===========");
            val = p.Max(x => x.salary);
            Console.WriteLine("Max of All salery  : " + val);

            Console.WriteLine("\n===== MIn ===========");
            val = p.Min(x => x.salary);
            Console.WriteLine("MIn of All salery  : " + val);

            Console.WriteLine("\n===== Averg ===========");
            var val1 = p.Average(x => x.salary);
            Console.WriteLine("Averge of All salery  : " + val1);

            Console.WriteLine("\n===== count ===========");
            val = p.Count();
            Console.WriteLine("Count of All Records : " + val);

            #endregion


            //______________________ 5. Element Operators __________________
            #region ElementOperation
            Console.WriteLine("\n===== First ===========");
            var el = p.First();
            Console.WriteLine("First Record : " + el.Id + ' ' + el.Name + ' ' + el.salary);

            Console.WriteLine("\n===== Last ===========");
            el = p.Last(x=>x.Age>15);
            Console.WriteLine("Last Record : " + el.Id + ' ' + el.Name + ' ' + el.salary);

            Console.WriteLine("\n===== First OR Default ===========");
            el = p.FirstOrDefault(p=>p.salary>25);
            Console.WriteLine("Last Record : " + el.Id + ' ' + el.Name + ' ' + el.salary);

            Console.WriteLine("\n===== Last of Default ===========");
            el = p.LastOrDefault(p => p.salary > 20);
            Console.WriteLine("Last Record : " + el.Id + ' ' + el.Name + ' ' + el.salary);
            #endregion

            //______________________ 6. Set Operators __________________
            #region Set_Operators
            Console.WriteLine("\n===== Distinct() Unique Values ===========");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            var distinctNumbers = numbers.Distinct();
            foreach (int number in distinctNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n===== Union (Combin to Array , Object) but Unique Values===========");
            List<int> numbers1 = new List<int> { 11, 21, 31 };
            var Numbers = numbers.Union(numbers1);
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }

            #endregion

            //______________________ 7. Partitioning Operators __________________
            #region Partition Op
            Console.WriteLine("\n===== Take(2....) (show only  Taken Elements) ===========");
            var partition = p.Take(2);
            foreach (var item in partition)
            {
                Console.WriteLine("Last Record : " + item.Id + ' ' + item.Name + ' ' + item.salary);
            }

            Console.WriteLine("\n===== skip(2....) (ignor number of values which you gives) ===========");
            partition = p.Skip(2);
            foreach (var item in partition)
            {
                Console.WriteLine("Last Record : " + item.Id + ' ' + item.Name + ' ' + item.salary);
            }

            Console.WriteLine("\n===== skip(2).take(2)===========");
            partition = p.Skip(2).Take(2);
            foreach (var item in partition)
            {
                Console.WriteLine("Last Record : " + item.Id + ' ' + item.Name + ' ' + item.salary);
            }

            Console.WriteLine("\n===== Showing 2nd from last Record===========");
            partition = p.OrderByDescending(x => x.Id).Skip(1).Take(1);
            foreach (var item in partition)
            {
                Console.WriteLine("Last Record : " + item.Id + ' ' + item.Name + ' ' + item.salary);
            }

            Console.WriteLine("\n===== Take 2nd Heighest Salary Record ===========");
            partition = p.OrderByDescending(x => x.salary).Skip(1).Take(1);
            foreach (var item in partition)
            {
                Console.WriteLine("Last Record : " + item.Id + ' ' + item.Name + ' ' + item.salary);
            }

            #endregion


            //______________________ 8. Grouping  Linque __________________
            #region 3. Grouping
            Console.WriteLine("\n==================== Grouping By (department) ================");
            var p2 = p.GroupBy(x => x.department);
            foreach (var item in p2)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine("{0}", (item1.salary));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n============== Grouping By (department) + sum by Salary ==============");
            var p3 = p.GroupBy(x => x.department).Select(g => new { Department = g.Key , TotalSalary = g.Sum(e => e.salary) });
            foreach (var item in p3)
            {
                Console.WriteLine("Dep : " + item.Department  + " , Total Salary : " + item.TotalSalary);
            }

            Console.WriteLine("\n============== Grouping By (department) + Averg Salary ==============");
            var p4 = p.GroupBy(x => x.department).Select(g => new { Department = g.Key, TotalSalary = g.Average(e => e.salary) });
            
            foreach (var item in p4)
            {
                Console.WriteLine("Dep : " + item.Department + " , Avg Salary : " + item.TotalSalary);
            }
            #endregion

            //______________________ 9. Joins Linque __________________
            #region Join_2_class
            var employee_Orders = new List<employee_Orders>
            {
                new employee_Orders{ empId = 1, productQuantity = 5, Amount = 90 },
                new employee_Orders{ empId = 2, productQuantity = 2, Amount = 130 },
                new employee_Orders{ empId = 3, productQuantity = 7, Amount = 150 },
            };
            Console.WriteLine("\n====================== Joins_1 ==============================");
            /*
             p.Joint(classNmae, ___Id, ____Id  (same Ids in both class)    ,  (x,y){.... get.... values})
             */
            var result1 = p.Join(employee_Orders, emp=>emp.Id, ord=>ord.empId , (emp, ord) => new { EmployeeName = emp.Name , Quantity = ord.productQuantity , quantityPrice = ord.Amount , totalPrice = ord.Amount*ord.productQuantity} );

            foreach (var item in result1)
            {
                Console.WriteLine("EmployeeName = {0} , Quantities = {1} , QuantityAmount = {2} , TotalAmount = {3}", item.EmployeeName, item.Quantity , item.quantityPrice , item.totalPrice);
            }

            Console.WriteLine("\n====================== Joins_2 ==============================");
            var people = new List<Person>
            {
                new Person { Id = 1, Name = "John", Age = 30 },
                new Person { Id = 2, Name = "Jane", Age = 25 },
                new Person { Id = 3, Name = "Bob", Age = 40 }
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, OrderDate = new DateTime(2022, 3, 1), Total = 100 },
                new Order { Id = 2, OrderDate = new DateTime(2022, 3, 2), Total = 200 },
                new Order { Id = 3, OrderDate = new DateTime(2022, 3, 3), Total = 300 }
            };

            var result = people.Join(orders, person => person.Id, order => order.Id,
                (person, order) => new { 
                    PersonName = person.Name, 
                    OrderTotal = order.Total 
                }
             );

            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.PersonName, item.OrderTotal);
            }

            #endregion


            practice:
            
            Console.WriteLine("\n===== Distinct() Unique Values ===========");
            List<int> n = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            int[] myn = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            var dis = n.Distinct();
            var d = myn.Distinct();

            foreach (int number in d)
            {
                Console.WriteLine(number);
            }

        }
    }
}
