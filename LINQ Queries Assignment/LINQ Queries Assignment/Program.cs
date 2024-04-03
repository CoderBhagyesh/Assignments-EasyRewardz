using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System;
using System.Text.Json;

namespace LINQ_Queries_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Write a LINQ query to find the three highest-scoring students from a list of student objects.
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Name = "Aman",
                    Marks = 70
                },
                new Student()
                {
                    Name = "Bhagyesh",
                    Marks = 80
                },
                new Student()
                {
                    Name = "Ankit",
                    Marks = 92
                },
                new Student()
                {
                    Name = "lovely",
                    Marks = 65
                }
            };

            // LINQ query from
            var query = (from student in students
                        orderby student.Marks descending
                        select student).Take(3);

            // LINQ method form
            var queryMethod = students.OrderByDescending(student => student.Marks).Take(3).Select((student => student)); 

            foreach (var student in queryMethod)
            {
                Console.WriteLine(student.Name + " " + student.Marks);
            }

            // Task 2: Implement a LINQ query to retrieve the most expensive product from a list of products.
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductName = "Book",
                    Price = 30
                },
                new Product
                {
                    ProductName = "Pen",
                    Price = 10
                },
                new Product
                {
                    ProductName = "Bag",
                    Price = 400
                }
            };

            var queryP = (from product in products
                        orderby product.Price descending
                        select product).Take(1);

            var queryMethodP = products.OrderByDescending(product => product.Price).Take(1);

            foreach (var product in queryMethodP)
            {
                Console.WriteLine(product.ProductName + " " + product.Price);
            }

            // Using LINQ with Additional Data Sources:
            // Task: Retrieve data from a JSON file using LINQ and perform data analysis(e.g., find the average age of users).
            string jsonFilePath = "C:\\Users\\ASUS\\OneDrive\\Desktop\\EasyRewardz Assignments\\LINQ Queries Assignment\\LINQ Queries Assignment\\Users.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            User[] users = JsonSerializer.Deserialize<User[]>(jsonString);

            var queryU = (from user in users
                        select user.age).Average();

            var queryMethodU = users.Average(user => user.age);

            
            Console.WriteLine(queryMethodU);


            //Advanced Data Manipulation:
            //Task 1: Implement a LINQ query to find the top-selling products by category from a list of sales data.
            string jsonPath = "C:\\Users\\ASUS\\OneDrive\\Desktop\\EasyRewardz Assignments\\LINQ Queries Assignment\\LINQ Queries Assignment\\Sales.json";
            string jsonStringSales = File.ReadAllText(jsonPath);

            Sale[] sales = JsonSerializer.Deserialize<Sale[]>(jsonStringSales);

            var querySales = (from sale in sales
                              select sale).OrderByDescending(sale => sale.totalOrders).GroupBy(sale => sale.category);

            var queryMethodSales = sales.OrderByDescending(sale => sale.totalOrders).GroupBy(sale => sale.category);
            foreach (var group in queryMethodSales)
            {
                Console.WriteLine("Category " + group.Key);
                foreach( var item in group)
                {
                    Console.WriteLine(item.name);
                    Console.WriteLine(item.totalOrders);
                }
            }                 

        //Task 2: Group sales data by month and calculate the total revenue for each month using LINQ.
         var query2Sales = (from sale in sales
                           select sale).GroupBy(sale => sale.month);
         



            //Custom Exception Handling:
            //Task: Define a custom exception class (e.g., CustomException) and throw this exception from a method in your program.
            //Write a try-catch block to catch and handle instances of the custom exception,
            //providing a meaningful error message.

            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if( n == 0 )
                {
                    throw new customException("number can not be 0");
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
}
}
