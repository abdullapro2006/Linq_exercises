// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Net.Cache;
using System.ComponentModel.DataAnnotations;

namespace Linq
{
    public class Program 
    {
        public static void Main(string[] args)
        {
           #region task1

            //    List<int> numbers = new List<int>() {0,1,2,3,4,5,6,7,8,9 };

            //    var result = numbers.Where(n => n % 2 == 0).ToList();

            //    foreach (int n in result) 
            //    {
            //        Console.WriteLine(n);
            //    }
            #endregion

           #region task2
            //List<int> list = new List<int>() { 1, 3, 6, 13, 10, 15, 20, 25 };

            //var result = list.Where(x => x <= 11).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

           #region task3
            //List<int> list = new List<int>() { 2,5,7,4,9,10,3};

            //var result = from int Number in list
            //            let SqrNo = Number * Number
            //            where SqrNo > 20
            //            select new { Number, SqrNo };

            //foreach ( var item in result )
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

           #region task6
            //List<string> weekday = new List<string>() {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };


            //var ShowConsoleWeekday = from weekdays in weekday
            //                         select weekdays;

            //Console.WriteLine("###### Weekdays:  #######");


            //foreach (var item in ShowConsoleWeekday)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
           
           #region task8
            //List<string> cities = new List<string>() { "Baku", "Moscow", "Ankara", "Tiflis", "Roma", "Istanbul" };


            //var result = cities.Where(c => c.StartsWith('B') || c.EndsWith('U')).ToList();
            //Console.WriteLine("The city starting with B and ending with U is : ");

            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

           #region task9
            //List<int> list = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };


            //var result = list.Where(x => x > 80).ToList();

            //Console.WriteLine(" ###### The numbers greater than 80 are :  ######");


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

           #region task11
            //List<int> numbers = new List<int>() { 10, 48, 52, 94, 63, 11 };

            //var result = numbers.Take(3);

            //Console.WriteLine("The top 3 records from the list are :");


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

           #region task17
            //List<char> list = new List<char>() {'m','n','o','p','q' };


            //var result = list.Remove('o');

            //foreach (char c in list)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

           #region task18
            //List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };


            //var result = list.Remove('p');

            //foreach (char c in list)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

           #region task19
            //List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };


            //var result = list.Remove('q');

            //foreach (char c in list)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

           #region task20
            // List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //list.RemoveAt(3);

            // foreach (char c in list)
            // {
            //     Console.WriteLine(c);
            // }

            #endregion

           #region task21

            //List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //list.RemoveRange(1, 3);

            //foreach (char c in list)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

           #region task30
            //List<string> list = new List<string>() {"Biscuit","Butter","Honey","Brade" };

            //  var result = from l in list
            //               orderby l ascending
            //               select l;


            //  foreach (var item in result)
            //  {
            //      Console.WriteLine(item);
            //  }
            #endregion

        }



    }

    
}
