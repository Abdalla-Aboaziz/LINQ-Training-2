using DemoG01.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static DemoG01.Data.ListGenerator;
namespace LINQ_Training_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            #region Q1
            /*. Get first Product out of Stock */

            //var result = ProductList.Where(p => p.Category == "Beverages").FirstOrDefault();
            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2
            /*Return the first product whose Price > 1000, unless there is no match, in which case null is returned.*/

            //var result = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault(p=>p.UnitPrice>1000,null);
            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            /* Retrieve the second number greater than 5 */

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //// var result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //// Console.WriteLine(result);



            //var result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion


            #region Aggregate Operators

            #region Q1
            /*Uses Count to get the number of odd numbers in the array*/

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(P => P % 2 != 0);
            //Console.WriteLine(result);

            #endregion

            #region Q2
            /*Return a list of customers and how many orders each has.*/
            //var result = CustomerList.Select(n => new
            //{
            //    n.CustomerName,
            //    OrderCount = n.Orders.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3

            /*Return a list of categories and how many products each has */

            //var result = ProductList.Select(n => new
            //{
            //    n.Category,
            //    Count=ProductList.Count(p=>p.Category==n.Category)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            /*. Get the total of the numbers in an array.*/

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            // Console.WriteLine(result);


            #endregion

            #region Q5
            /*Get the total number of characters of all words in dictionary_english.txt 
             * (Read dictionary_english.txt into Array of String First).*/

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(n => n.Length);
            //Console.WriteLine(result);


            #endregion

            #region Q6
            /*. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).*/

            //String[] Words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Min(p => p.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q7
            /*. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).*/

            //String[] Words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Max(p => p.Length);
            //Console.WriteLine(result);

            #endregion

            #region Q8
            /*Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).*/

            //String[] Words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Average(p => p.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q9
            /*Get the total units in stock for each product category.*/
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Q10

            /*. Get the cheapest price among each category's products*/

            //var result =ProductList.GroupBy(p=>p.Category).Select(g => new
            //{

            //  Cheapest = g.MinBy(p => p.UnitPrice)

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q11
            /*. Get the products with the cheapest price in each category (Use Let)*/

            //var result = from p in ProductList
            //             let minPrice = ProductList.Where(x => x.Category == p.Category).Min(x => x.UnitPrice)
            //             where p.UnitPrice == minPrice
            //                select new
            //                {
            //                    p.Category,
            //                    p.ProductName,
            //                    p.UnitPrice
            //                };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q12
            /*. Get the most expensive price among each category's products.*/
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    MostExpensiveProducts =  g.Max(x => x.UnitPrice)
            //});
            //int n = 0;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion


            #region Q13
            /*. Get the products with the most expensive price in each category.*/

            //var result = ProductList.GroupBy(p=>p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(x => x.UnitPrice))
            //});
            //int n = 0;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Categorey {n++}");
            //    foreach (var c in item.MostExpensiveProducts)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}

            #endregion

            #region Q14

            /*Get the average price of each category's products.*/


            //var result =ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //   Average = g.Average(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion






            #endregion


            #region Set Operators

            #region Q1
            /*Find the unique Category names from Product List*/
            //var result = ProductList.Select(p=>p.Category).Distinct();
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Q2
            /*Produce a Sequence containing the unique first letter from both product and customer names.*/
            //var result = ProductList.Select(p => p.ProductName![0])
            //    .Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            /*Create one sequence that contains the first letters of product names
              that are not also first letters of customer names.*/

            //var result = ProductList.Select(p => p.ProductName![0])
            //    .Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #region Q3

            #region Q4

            /*Create one sequence that contains the first letters of product names that are not also first letters of customer names.*/
            //var result = ProductList.Select(p => p.ProductName![0])
            //    .Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5
            /* Create one sequence that contains the last Three Characters in each name of all customers and products,
             * including any duplicates*/

            //var result = ProductList.Select(p => p.ProductName[^3..])//take last (3) 
            //    .Concat(CustomerList.Select(c => c.CustomerName[^3..]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion





            #endregion





            #endregion


            #region Partitioning Operators

            #region Q1
            /*Get the first 3 orders from customers in Washington*/

            //var result = CustomerList.Where(p=>p.Address== "Washington").SelectMany(c=>c.Orders).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2

            #endregion

            #region Q3
            /*. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            */
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((N,I)=>N>I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4
            /*.Get the elements of the array starting from the first element divisible by 3.
            int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            */

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(p=>p%3==0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q5
            /*Get the elements of the array starting from the first element less than its position.
            int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            */
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((N, I) => N > I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion






            #endregion


            #region Quantifiers

            #region Q1
            /*. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt
             * into Array of String First) 
             * contain the substring 'ei'*/
            //var result = System.IO.File.ReadAllLines("dictionary_english.txt");

            //var hasEi = result.Any(word => word.Contains("ei"));
            //Console.WriteLine(hasEi);

            #endregion

            #region Q2
            /*2. Return a grouped list of products only for categories that have at least one product that is out of stock.*/
            //var result2 = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach (var group in result2)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product}");
            //    }

            //}

            #endregion


            #region Q3
            /*Return a grouped list of products only for categories that have all of their products in stock.*/
            //var result3 = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var item in result3)
            //{
            //    foreach (var p in item)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}
            #endregion





            #endregion


            #region Grouping Operators

            #region Q1
            /*1.	Use group by to partition a list of numbers by their remainder when divided by 5

            List<int> numbers = new list<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            */

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5)
            //                    .Select(g => new
            //                    {
            //                        Remainder = g.Key,
            //                        Numbers = g.ToList()
            //                    });
            //foreach (var group in result)
            //{
            //   foreach (var item in group.Numbers)
            //    {
            //        Console.WriteLine($"Remainder: {group.Remainder}, Number: {item}");
            //    }
            //}

            #endregion


            #region Q2
            /*2.	Uses group by to partition a list of words by their first letter.
           Use dictionary_english.txt for Input
        */
            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.GroupBy(w => w[0])
            //                    .Select(g => new
            //                    {
            //                        FirstLetter = g.Key,
            //                        Words = g.ToList()
            //                    });

            //foreach (var group in result)
            //{
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine($"First Letter: {group.FirstLetter}, Word: {word}");
            //    }
            //}

            #endregion


                #endregion


        }
    }
}
