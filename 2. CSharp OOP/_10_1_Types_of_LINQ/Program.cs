using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_1_Types_of_LINQ
{

    internal class Program
    {
        //___________________ 1. Linq to Object ___________________
        public class linqueToObject
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string department { get; set; }
        }




        static void Main(string[] args)
        {
            //same above work in Query Linque
            Console.WriteLine("=========== Basice Select Query LINQ (like SQL) ===============");
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 5, 5, 8, 0 };
            var selectNumber = (from x in numbers2
                                  select x).ToList();
            foreach (var item in selectNumber)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();


            //______________ 2 Types of LINQ ___________________

            //================= 1. Method LINQ ================
            ////abhi take jo  LINQ  hm na parha wo  yaa thaa
            Console.WriteLine("=========== 1. Method LINQ ===============");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 5, 5, 8, 0 };
            var evenNumber_dubleValue = numbers.Where(n => n % 2 == 0).Select(n => n * 2).ToList();
            foreach (var item in evenNumber_dubleValue)
            {
                Console.WriteLine(item);
            }

            //================= 2. Query LINQ ================
            //same above work in Query Linque
            Console.WriteLine("=========== 2. Query LINQ (like SQL) ===============");
            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 5, 5, 8, 0 };
            var evenNumber_dubleValue1 = (from n in numbers1
                                          where n % 2 == 0
                                          select n * 2).ToList();
            foreach (var item in evenNumber_dubleValue1)
            {
                Console.WriteLine(item);
            }

            //================= when To Use Query LINQ ================
            //When we   Complex Scenarios 


            //=====================================================
            //======================================= Query LINQ use With =====================================
            //=====================================================

            //_____________________ 1. LINQ to Object (class) ___________________
            #region 1. LINQ to Object
            //____ by Array/List
            int[] n1 = { 1, 2, 3, 4, 5 };
            var evenNumbers = from n in n1
                              where n % 2 == 0
                              select n;

            //____ by List (class) ___
            List<linqueToObject> lObject = new List<linqueToObject>
            {
                new linqueToObject(){id=1,Name="Saqib",department="IT"},
                new linqueToObject(){id=2,Name="Sajid",department="IT"},
                new linqueToObject(){id=3,Name="Raja",department="Peon"},
                new linqueToObject(){id=4,Name="Aqib",department="Gard"},
                new linqueToObject(){id=5,Name="Rashid",department="IT"},
                new linqueToObject(){id=6,Name="Noman",department="IT"}
            };
            var evenNumber1 = from n in lObject
                              where n.department == "IT"
                              select n;
            foreach (var item in evenNumber1)
            {
                Console.WriteLine("Id : "+ item.id + " , name : " + item.Name);
            }
            #endregion

            //_____________________ 2. LINQ to  XML _________________
            //// Query an XML document using LINQ to XML
            //XDocument xmlDocument = XDocument.Load("books.xml");
            //var bookTitles = from book in xmlDocument.Descendants("book")
            //                 select book.Element("title").Value;
            //// Output: Harry Potter, The Lord of the Rings, The Hobbit,
            ///

            //_____________________ 3. LINQ to SQL ||| Entity_________________
            //// Query a SQL database using LINQ to SQL
            //using (var db = new MyDatabaseDataContext())  
            //{
            //    var customers = from c in db.Customers
            //                    where c.City == "London"
            //                    select c;
            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine(customer.Name);
            //    }
            //    // Output: John Smith, Jane Doe
            //}



            //_____________________ 4. Grouping and Aggregation _________________
            //// Group and aggregate data using LINQ
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var groups = from n in numbers
            //             group n by n % 2 into g
            //             select new { Key = g.Key, Count = g.Count(), Sum = g.Sum() };
            //foreach (var group in groups)
            //{
            //    Console.WriteLine("Key: {0}, Count: {1}, Sum: {2}", group.Key, group.Count, group.Sum);
            //}
            //// Output: Key: 1, Count: 3, Sum: 9, Key: 0, Count: 2, Sum: 6


            //_____________________ 5. Deferred Execution: _________________
            //// Use deferred execution to improve performance
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var evenNumbers = from n in numbers
            //                  where n % 2 == 0
            //                  select n;
            //// Perform other computations
            //int sum = evenNumbers.Sum();
            //Console.WriteLine("Sum of even numbers: {0}", sum);
            //// Output: Sum of even numbers: 6


            //_____________________ 6. Query Optimization: _________________
            //// Optimize a query using filtering, projection, and sorting
            //using (var db = new MyDatabaseContext())
            //{
            //    var products = from p in db.Products
            //                   where p.Category.Name == "Books"
            //                   select new { Name = p.Name, Price = p.Price * 0.9 };
            //    var sortedProducts = products.OrderBy(p => p.Name);
            //    foreach (var product in sortedProducts)
            //    {
            //        Console.WriteLine("Name: {0}, Price: {1}", product.Name, product.Price);
            //    }
            //    // Output: Name: Harry Potter, Price: 18.9, Name: The Hobbit, Price: 10.79, Name: The Lord of the Rings, Price: 26.99
            //}


            //_____________________ 7. Joining: _________________
            // Join two collections using LINQ
            var customers = new[] {
                new { Id = 1, Name = "John Smith", City = "London" },
                new { Id = 2, Name = "Jane Doe", City = "Paris" },
                new { Id = 3, Name = "Bob Johnson", City = "New York" }
            };
                        var orders = new[] {
                new { Id = 1, CustomerId = 1, Amount = 100 },
                new { Id = 2, CustomerId = 2, Amount = 200 },
                new { Id = 3, CustomerId = 1, Amount = 150 },
                new { Id = 4, CustomerId = 3, Amount = 300 }
            };
            var results = from c in customers
                          join o in orders on c.Id equals o.CustomerId
                          select new { CustomerName = c.Name, OrderAmount = o.Amount };
            foreach (var result in results)
            {
                Console.WriteLine("{0}: {1}", result.CustomerName, result.OrderAmount);
            }
            // Output: John Smith: 100, Jane Doe: 200, John Smith: 150, Bob Johnson: 300


            //_____________________ 8. Conversion Operators _________________

            // Convert between different collection types using LINQ
            string[] words = { "hello", "world" };
            List<string> wordList = words.ToList();
            HashSet<string> wordSet = words.ToHashSet();
            Dictionary<int, string> wordDict = words.Select((w, i) => new { Index = i, Word = w }).ToDictionary(w => w.Index, w => w.Word);


            //=====================================================
            //======================================= Advance Query =====================================
            //====================================================

            //________________ 1. ________________
            //Suppose we have two lists of objects, students and courses, where each Student object contains a list of Course objects that they are enrolled in. We want to find the average grade of each student across all their courses, but only for students who are over 18 years old and are enrolled in at least one course with a grade higher than 80.
            //var result = from s in students
            //             where s.Age > 18 && s.Courses.Any(c => c.Grade > 80)
            //             select new
            //             {
            //                 Name = s.Name,
            //                 AverageGrade = s.Courses.Average(c => c.Grade)
            //             };




            //________________ 2. ________________
            //We want to find the average salary of employees in each department, but only for departments where the average salary is greater than $60,000. We can use a LINQ query to accomplish this:

            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee { Id=1 ,Name = "Alice", Age = 25 , Salary=50000, Department="HR"},
            //    new Employee { Id=2 ,Name = "Bob", Age = 30 , Salary=60000, Department="Employee"},
            //    new Employee { Id=3 ,Name = "Charlie", Age = 35, Salary=70000, Department="Worker" },
            //    new Employee { Id=4 ,Name = "Sajid", Age = 35, Salary=55000, Department="Admin" },
            //    new Employee { Id=5 ,Name = "Noman", Age = 35, Salary=45000, Department="Peon" },
            //    new Employee { Id=6 ,Name = "Akram", Age = 35, Salary=80000, Department="Gard" },
            //    new Employee { Id=7 ,Name = "Ali", Age = 35, Salary=90000, Department="Saark" }
            //};

            //var result = employees
            //    .GroupBy(e => e.Department)
            //    .Select(g => new { Department = g.Key, AvgSalary = g.Average(e => e.Salary) })
            //    .Where(d => d.AvgSalary > 60000);



            //________________________ 3. Left Join ___________________________________
            ////Let's say we have two lists: a list of employees and a list of departments. Each employee has a DepartmentId that corresponds to the Id of the department they work in. We want to get a list of all employees and their corresponding department names, even if they don't have a department assigned (which would result in a null value for department name).

            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
            //    new Employee { Id = 2, Name = "Bob", DepartmentId = 2 },
            //    new Employee { Id = 3, Name = "Charlie", DepartmentId = 2 },
            //    new Employee { Id = 4, Name = "Dave", DepartmentId = null }
            //};

            //            List<Department> departments = new List<Department>
            //{
            //    new Department { Id = 1, Name = "HR" },
            //    new Department { Id = 2, Name = "Sales" },
            //    new Department { Id = 3, Name = "Marketing" }
            //};

            //var query = from emp in employees
            //            join dept in departments on emp.DepartmentId equals dept.Id into empDept
            //            from ed in empDept.DefaultIfEmpty()
            //            select new { EmployeeName = emp.Name, DepartmentName = ed?.Name };

            //foreach (var result in query)
            //{
            //    Console.WriteLine($"Employee: {result.EmployeeName}, Department: {result.DepartmentName ?? "N/A"}");
            //}



            //__________________________ Complex 20 LIne ____________________
            //Here's an example of a complex LINQ query with at least 20 lines. This query retrieves a list of customers with their total order value for each year, sorted by the total order value in descending order:
            //var customerOrders = from c in customers
            //                     join o in orders on c.CustomerID equals o.CustomerID into customerOrdersGroup
            //                     from co in customerOrdersGroup.DefaultIfEmpty()
            //                     group co by new { Year = co == null ? 0 : co.OrderDate.Year, CustomerID = c.CustomerID } into yearGroup
            //                     select new
            //                     {
            //                         Year = yearGroup.Key.Year,
            //                         CustomerID = yearGroup.Key.CustomerID,
            //                         TotalOrderValue = yearGroup.Sum(x => x == null ? 0 : x.Total)
            //                     };

            //var result = from co in customerOrders
            //             join c in customers on co.CustomerID equals c.CustomerID
            //             orderby co.Year descending, co.TotalOrderValue descending
            //             select new
            //             {
            //                 Year = co.Year,
            //                 CustomerID = c.CustomerID,
            //                 CompanyName = c.CompanyName,
            //                 TotalOrderValue = co.TotalOrderValue
            //             };

        }
    }
}
