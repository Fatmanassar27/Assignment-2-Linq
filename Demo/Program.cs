using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static Demo.ListGenerator;

namespace Demo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //List<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] products = ProductsList.Where(P => P.UnitsInStock == 0).ToArray();

            //HashSet<Product> results = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //Dictionary<long , Product> result = ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID );

            //Dictionary<long , string> result01 = ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID , P => P.ProductName );

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ali" ,
            //    "Ahmed" ,
            //    "Zeyad" ,
            //    1 ,
            //    2,
            //    3
            //};
            //var Result01 = arrayList.OfType<string>();
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Part 2
            //var Result = Enumerable.Range(0, 100);
            //var Result01 = Enumerable.Repeat( 2, 100);
            //var Result02 = Enumerable.Empty<Product>();

            //foreach (var item in Result01)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region Part 3
            //var seq01 = Enumerable.Range(0, 100);
            //var seq02 = Enumerable.Range(50, 100);

            //var Result = seq01.Union(seq02);
            //Result = seq01.Except(seq02);
            //Result = seq01.Intersect(seq02);
            //Result = seq01.Concat(seq02);
            //Result = seq01.Distinct();
            //Console.WriteLine("\n====================seq01===================");
            //foreach (var item in seq01)
            //{
            //    Console.Write($"{item} , ");
            //}

            //Console.WriteLine("\n====================seq02===================");

            //foreach (var item in seq02)
            //{
            //    Console.Write($"{item} , ");
            //}

            //Console.WriteLine("\n====================Result===================");

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} , ");
            //} 
            #endregion

            #region Part 4
            //var Result = ProductsList.Any();
            //Result = ProductsList.Any(P => P.UnitsInStock == 0);
            //Result = ProductsList.Any(P => P.UnitsInStock > 1000);
            //Result = ProductsList.All(P => P.UnitsInStock == 0);
            //Result = ProductsList.All(P => P.UnitsInStock >= 0);

            //var seq01 = Enumerable.Range(0, 100);
            //var seq02 = Enumerable.Range(50, 100);
            //seq02 = Enumerable.Range(0, 100);

            //var Result01 = seq01.SequenceEqual(seq02);
            //Console.WriteLine(Result01); 
            #endregion

            #region Part 5
            //int [] seq01 = Enumerable.Range(1, 10).ToArray();
            //string[] Names = { "Ahmed", "Aly", "Mona", "Aliaa", "Zeyad" };
            //char[] Chars = { 'a', 'b', 'c', 'e' };
            //var Result = Names.Zip(seq01);
            //var Result01 = Names.Zip(seq01, Chars);
            //var Result02 = Names.Zip(seq01,(N,I) => new {Index = I , Name = N });
            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Part 6

            //var Result01 = ProductsList.GroupBy(P => P.Category);

            //Result01 = from P in ProductsList
            //           group P by P.Category;


            //var Result02 = ProductsList.Where(P => P.UnitsInStock > 0)
            //                           .GroupBy(P => P.Category);

            //Result02 = from P in ProductsList
            //           where P.UnitsInStock > 0
            //           group P by P.Category;

            //var Result03 = ProductsList.Where(P => P.UnitsInStock > 0)
            //                           .GroupBy(P => P.Category)
            //                           .Where(P => P.Count() > 10);

            //Result03 = from P in ProductsList
            //           where P.UnitsInStock > 0
            //           group P by P.Category
            //           into Category 
            //           where Category.Count() > 10
            //           select Category;

            //var Result04 = ProductsList.Where(P => P.UnitsInStock > 0)
            //                           .GroupBy(P => P.Category)
            //                           .Where(P => P.Count() > 10)
            //                           .Select(P => new 
            //                           {
            //                               CategoryName = P.Key ,
            //                               Count = P.Count(),
            //                           });

            //Result04 = from P in ProductsList
            //           where P.UnitsInStock > 0
            //           group P by P.Category
            //           into Category
            //           where Category.Count() > 10
            //           select new 
            //           {
            //               CategoryName = Category.Key,
            //               Count = Category.Count(),
            //           };

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var Result in Result03)
            //{
            //    Console.WriteLine(Result.Key);
            //    foreach (var Item in Result)
            //        Console.WriteLine($"           {Item.ProductName}");

            //} 
            #endregion

            #region Part 7
            //var Result = ProductsList.Take(10);
            //Result = ProductsList.TakeLast(10);
            //Result = ProductsList.Skip(10);
            //Result = ProductsList.SkipLast(10);

            //int[] numbers = { 4, 5, 6, 41, 84, 26, 81, 6, 16, 15, 2, 7, 2, 3, 5, 4 };
            //var Result01 = numbers.TakeWhile(num => num % 3 != 0);
            //Result01 = numbers.SkipWhile(num => num % 3 != 0);
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Part 8
            //List<String> Names = new List<string> { "Ahmed", "Fatma", "Shimaa", "Rokaya" , "Mohamed" };

            //var Result = from N in Names
            //             select Regex.Replace(N , "[AEIOUaeiou]" ,string.Empty)
            //             into NoVauls 
            //             where NoVauls.Length > 3 
            //             select NoVauls;

            //Result = from N in Names
            //         let NoVauls = Regex.Replace(N, "[AEIOIaeiou]", string.Empty)
            //         where NoVauls.Length > 3
            //         select NoVauls;

            //foreach (var N in Result) 
            //    Console.WriteLine(N); 
            #endregion

        }
    }
}
