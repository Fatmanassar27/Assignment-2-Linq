using Demo;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static Demo.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment
{
    class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }

        public string Sort(string? x)
        {
            var chars = x.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //// Find all products that are out of stock.
            //var Result01 = ProductsList.Where(P => P.UnitsInStock ==0 );

            ////Find all products that are in stock and cost more than 3.00 per unit.
            //var Result02 = ProductsList.Where(P => P.UnitsInStock ==0 && P.UnitPrice > 3.00M);

            //// Returns digits whose name is shorter than their value
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result03 = Arr.Where((E, I) => E.Length < I);


            //foreach (var Product in Result03)
            //    Console.WriteLine(Product); 
            #endregion

            #region Element Operators
            //// Get first Product out of Stock 
            //var Result01 = ProductsList.First(P => P.UnitsInStock == 0);

            //// 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result02 = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);

            //// 3. Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result03 = Arr.Where(N => N > 5).ElementAt(1);

            //Console.WriteLine(Result03); 
            #endregion

            #region Aggregate Operators

            #region Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result01 = Arr.Count(N => N % 2 == 1);
            //Console.WriteLine(Result01);
            #endregion

            #region  Return a list of customers and how many orders each has.


            //var Result02 = CustomersList.Select(C => new
            //{
            //    C.CustomerName,
            //    OrderCount = C.Orders.Count(),
            //});
            #endregion

            #region Return a list of categories and how many products each has

            //var Result03 = ProductsList.Select(P => new
            //{
            //    P.ProductName,
            //    NumOfProduct = P.Category.Count(),
            //});

            //foreach ( var C in Result03 ) 
            //    Console.WriteLine(C);
            #endregion

            #region Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadLines("dictionary_english.txt");
            //var Result = Words.Sum(X => X.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Min(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the longest length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Max(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Average(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the total units in stock for each product category.
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category);
            //var Result01 = from P in Result
            //               select new
            //               {
            //                   Category = P.Key,
            //                   Count = P.Sum(P => P.UnitsInStock),
            //               };
            //foreach (var Item in Result01)
            //{
            //    Console.WriteLine(Item);
            //} 
            #endregion

            #region  Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(P => P.Category);
            //var Result01 = from R in Result
            //               select new
            //               {
            //                   category = R.Key,
            //                   cheapest = R.Min(x  => x.UnitPrice),
            //               };
            #endregion

            #region Get the products with the cheapest price in each category (Use let )
            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into New
            //             let price = New.Where(X => X.UnitPrice == New.Min(Y => Y.UnitPrice))
            //             select price; 
            #endregion

            #region  Get the most expensive price among each category's products.
            //var Result = ProductsList.GroupBy(P => P.Category).Select (P => new 
            //{
            //    Category = P.Key,
            //    Expensive = P.Max( X => X.UnitPrice )
            //}); 
            #endregion

            #region Get the products with the most expensive price in each category.
            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into New
            //             let price = New.Where(X => X.UnitPrice == New.Max(Y => Y.UnitPrice))
            //             select price; 
            #endregion

            #region Get the average price of each category's products.
            //var Result = ProductsList.GroupBy(P => P.Category).Select(X => new
            //{
            //    Category = X.Key,
            //    Average = X.Average(X => X.UnitPrice),
            //});

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //} 
            #endregion

            #endregion

            #region Ordering Operators
            #region  Sort a list of products by name
            //var Result = ProductsList.OrderBy(P => P.ProductName);

            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion

            #region Uses a custom comparer to do a case -insensitive sort of the words in an array
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //CaseInsensitiveComparer Compare = new CaseInsensitiveComparer();

            //Array.Sort(Arr,Compare);

            //foreach (var x in Arr) 
            //    Console.WriteLine(x); 
            #endregion

            #region Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductsList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var result in Result) 
            //     Console.WriteLine(result); 
            #endregion

            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.OrderBy(X => X.Length).ThenBy(X => X);

            //foreach (var x in Result) 
            //    Console.WriteLine(x); 
            #endregion

            #region Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x => x , StringComparer.OrdinalIgnoreCase).ToArray();

            //foreach (var x in Result) 
            //    Console.WriteLine(x); 
            #endregion

            #region Sort a list of products, first by category, and then by unit price, from highest to lowest
            //var Result = ProductsList.OrderBy(X => X.Category).ThenByDescending(Y => Y.UnitPrice);
            #endregion

            #region Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x , StringComparer.OrdinalIgnoreCase);
            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion

            #region Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Reverse();
            //List<string> list = Result.Where(x => x[1] == 'i').ToList();

            //foreach (string str in list)
            //    Console.WriteLine(str); 
            #endregion

            #endregion

            #region Transformation Operators

            #region Return a sequence of just the names of a list of products.
            // var Result = ProductsList.Select(x => x.ProductName); 
            #endregion

            #region .Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(x => new
            //{
            //    LowerCase = x.ToLower(),
            //    UpperCase = x.ToUpper(),
            //});

            #endregion

            #region Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ProductsList.Select(X => new
            //{
            //    X.ProductID,
            //    X.ProductName,
            //    Price = X.UnitPrice,
            //});
            //foreach (var result in Result)
            //    Console.WriteLine(result); 
            #endregion

            #region Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((E, I) => (E , E == I));
            //foreach (var E in Result) 
            //    Console.WriteLine(E); 
            #endregion

            #region Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = from A in numbersA
            //             from B in numbersB
            //             where A < B 
            //             select new { A, B };


            //foreach (var result in Result) 
            //        Console.WriteLine($" {result.A} is Less Than {result.B} "); 
            #endregion

            #region Select all orders where the order total is less than 500.00.
            //var Result = CustomersList.SelectMany(p => p.Orders).Where(P => P.Total < 500.00M);
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            #endregion

            #region Select all orders where the order was made in 1998 or later.
            //var Result = CustomersList.SelectMany(P => P.Orders).Where(x => x.OrderDate.Year == 1998);
            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion
            #endregion

            #region Set Operators

            #region .Find the unique Category names from Product List
            //var Result = ProductsList.Select(P => P.Category).Union(ProductsList.Select(P => P.Category));
            //Result = ProductsList.Select(P => P.Category).Distinct();
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result = ProductsList.Select(P => P.ProductName[0]).Union(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var Result2 in Result)
            //    Console.WriteLine(Result2); 
            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var Result2 in Result)
            //    Console.WriteLine(Result2) 
            #endregion;

            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var Result2 in Result)
            //    Console.WriteLine(Result2); 
            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates 
            //var Result = ProductsList.Select(P => P.ProductName[^3..]).Concat(CustomersList.Select(C => C.CustomerName[^3..]));
            //foreach (var Result2 in Result)
            //    Console.WriteLine(Result2); 
            #endregion

            #endregion

            #region Partitioning Operators

            #region Get the first 3 orders from customers in Washington
            //var Result = CustomersList.Where(c => c.Region == "WA").SelectMany(C => C.Orders).Take(3);
            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion

            #region Get all but the first 2 orders from customers in Washington.
            //var Result = CustomersList.Where(c => c.Region == "WA").SelectMany(C => C.Orders).Skip(2);
            //foreach (var result in Result)
            //    Console.WriteLine(result); 
            #endregion

            #region Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((E,I) => E >= I);
            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion

            #region Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(X => X%3 != 0);  
            //foreach (var x in Result) 
            //    Console.WriteLine(x); 
            #endregion

            #region Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((E , I) => E >= I);
            //foreach (var result in Result) 
            //    Console.WriteLine(result); 
            #endregion

            #endregion

            #region Quantifiers

            #region Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var Result01 = File.ReadAllLines("dictionary_english.txt");
            //var Result02 = Result01.Any(x => x.Contains("ei"));
            //Console.WriteLine(Result02); 
            #endregion

            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result01 = ProductsList.GroupBy(P => P.Category).Where(p => p.Any(x => x.UnitsInStock == 0)).Select(p => p);
            //foreach (var Result02 in Result01)
            //{
            //    Console.WriteLine(Result02.Key);
            //    foreach (var Result03 in Result02)
            //        Console.WriteLine(Result03);

            //} 
            #endregion

            #region Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductsList.GroupBy(p => p.Category).Where(P => P.All(x => x.UnitsInStock >0)).Select(p => p);
            //foreach (var Result02 in Result)
            //{
            //    Console.WriteLine(Result02.Key);
            //    foreach (var Result03 in Result02)
            //        Console.WriteLine($"                {Result03}");
            //} 
            #endregion

            #endregion

            #region Grouping Operators

            #region Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(X => X % 5);
            //foreach (var Result02 in Result)
            //{
            //    Console.WriteLine($"Numbers with a reminder of {Result02.Key} when divided by 5");
            //    foreach (var Result03 in Result02)
            //        Console.WriteLine($"{Result03}");

            //}
            #endregion

            #region Uses group by to partition a list of words by their first letter.
            //var Result01 = File.ReadAllLines("dictionary_english.txt");
            //var Result02 = Result01.GroupBy(x => x[0]);
            //foreach (var Result03 in Result02)
            //{  
            //    Console.WriteLine($"words with letter {Result03.Key} is");
            //    foreach (var r in Result03)
            //        Console.WriteLine($"            {r}");
            //}
            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string [] Arr = { "from", "salt", "earn", " last", "near", "form"};

            //var Result = Arr.GroupBy(w => w.Trim(), new EqualityComparer());

            //foreach (var item in Result)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine("...............");
            //}
            #endregion
            #endregion

        }


    }
}
