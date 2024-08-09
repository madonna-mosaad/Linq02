using Linq001;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Element Operators
            #region Q01
            //var Result = ListGenerators.ProductsList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion
            #region Q02
            //var Result = ListGenerators.ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion
            #region 03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(i => i > 5).ToImmutableSortedSet().Skip(1).First();
            //Console.WriteLine(Result);
            #endregion
            #endregion
            #region Aggregate Operators
            #region 01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(i=>i%2==1);
            //Console.WriteLine(Result); 
            #endregion
            #region 02
            //var Result= ListGenerators.CustomersList.Select(c=>new {customer = c, count = c.Orders.Count() });
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 03
            //var Result = ListGenerators.ProductsList.GroupJoin(ListGenerators.ProductsList,
            //                                                   P => P.Category,
            //                                                   p => p.Category,
            //                                                   (p01,p02)=> new {category=p01.Category,count=p02.Count()})
            //                                          .Distinct();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion
            #region 05
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result= str.Sum(str=>str.Length);
            //Console.WriteLine(Result); 
            #endregion
            #region 06
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result= str.Min(x=> x.Length);
            //Console.WriteLine(Result);
            #endregion
            #region 07
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Max(x => x.Length);
            //Console.WriteLine(Result);
            #endregion
            #region 08
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Average(x => x.Length);
            //Console.WriteLine(Result);
            #endregion
            #region 09
            //var Result = ListGenerators.ProductsList.GroupJoin(ListGenerators.ProductsList,
            //                                                   P => P.Category,
            //                                                   p => p.Category,
            //                                                   (p01, p02) => new { category = p01.Category, total = p02.Sum(x=>x.UnitsInStock) })
            //                                          .Distinct();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 10
            //var Result = ListGenerators.ProductsList.GroupJoin(ListGenerators.ProductsList,
            //                                                   P => P.Category,
            //                                                   p => p.Category,
            //                                                   (p01, p02) => new { category = p01.Category, CheapestPrice = p02.Min(x=>x.UnitPrice) })
            //                                          .Distinct();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 11
            //var Result = from p in ListGenerators.ProductsList
            //             group p by p.Category into g
            //             let r = g.OrderBy(p => p.UnitPrice).First()
            //             select r;



            //foreach (var r in Result)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region 12
            //var Result = from p in ListGenerators.ProductsList
            //             group p by p.Category
            //             into g
            //             let r = g.OrderBy(g => g.UnitPrice).Last()
            //             select new {r.Category,r.UnitPrice};
            //foreach (var r in Result)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region 13
            //var Result = from p in ListGenerators.ProductsList
            //             group p by p.Category into g
            //             let r = g.OrderBy(p => p.UnitPrice).Last()
            //             select r;



            //foreach (var r in Result)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region 14
            //var Result = from p in ListGenerators.ProductsList
            //             group p by p.Category
            //             into g
            //             let r=g.Average(x=>x.UnitPrice)
            //             select new {category = g.First().Category,avg=r};
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region  Set Operators
            #region 01
            //var Result = ListGenerators.ProductsList.Select(p => p.Category).Distinct();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 02
            //var Result = ListGenerators.ProductsList.Select(p=>p.ProductName.First()).Union(ListGenerators.CustomersList.Select(c=>c.CustomerName.First()));
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 03
            //var Result = ListGenerators.ProductsList.Select(p => p.ProductName.First()).Intersect(ListGenerators.CustomersList.Select(c => c.CustomerName.First()));
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 04
            //var Result = ListGenerators.ProductsList.Select(p => p.ProductName.First()).Except(ListGenerators.CustomersList.Select(c => c.CustomerName.First()));
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 05
            //var Result = ListGenerators.ProductsList.Select(p => p.ProductName.TakeLast(3)).Concat(ListGenerators.CustomersList.Select(c => c.CustomerName.TakeLast(3)));
            //foreach (var result in Result)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.Write(item);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion
            #region  Partitioning Operators
            #region 01
            //var Result = ListGenerators.CustomersList.Where(c => c.City.Equals("Washington")).SelectMany(x=>x.Orders).Take(3);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //} 
            #endregion
            #region 02
            //var Result = ListGenerators.CustomersList.Where(c => c.City.Equals("Washington")).SelectMany(x => x.Orders).Skip(2);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((x, ind) => x > ind);
            //foreach (var x in Result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region 04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result= numbers.SkipWhile(x => x %3 !=0);
            //foreach (int i in Result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 05
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((x, ind) => x > ind);
            //foreach (var x in Result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #endregion
            #region Quantifiers
            #region 01
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Any(x => x.Contains("ei"));
            //Console.WriteLine(Result);
            #endregion
            #region 02
            //var Result = ListGenerators.ProductsList.GroupBy(p => p.Category).Where(p => p.Any(p=>p.UnitsInStock==0));
            //foreach (var result in Result)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region 03
            //var Result = ListGenerators.ProductsList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock != 0));
            //foreach (var result in Result)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #endregion
            #region  Grouping Operators
            #region 01
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(p => p % 5);
            //foreach(var result in Result)
            //{

            //    Console.WriteLine($"remibser of {result.Select(p=>p%5).First()}");
            //    foreach (var item in result) 
            //    {
            //        Console.WriteLine(item); 
            //    }
            //}
            #endregion
            #region 02
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.GroupBy(s=>s.First());
            //foreach (var result in Result)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region 03
            //String[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            //var Result = Arr.GroupBy(a => new string(a.Order().ToArray()));
            //foreach (var item in Result)
            //{

            //    foreach (var item2 in item)
            //    {

            //        Console.WriteLine(item2);
            //    }
            //    Console.WriteLine(".....");
            //}

            #endregion
            #endregion

        }
    }
}
