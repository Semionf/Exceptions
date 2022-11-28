using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string fileName;
            string[] arr;
            //Boolean ans = true;
            //Console.WriteLine("Please enter first number: ");
            //a = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Please enter second number: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    c = a / b;
            //    Console.WriteLine("The result is: " +c);
            //}
            //catch(DivideByZeroException ex1)
            //{
            //    Console.WriteLine("Result is infinite");
            //}

            //do
            //{
            //    ans = false;
            //    a = Convert.ToInt32(Console.ReadLine());
            //    try
            //    {
            //        c = 770 / a;
            //    }
               
            //    catch(DivideByZeroException ex1)
            //    {
            //        ans = true; 
            //    }
            //} while (ans);
            //try
            //{
            //    Console.WriteLine("Please enter file name: ");
            //    fileName = Console.ReadLine();
            //    StreamReader sr = new StreamReader(fileName);
            //    Console.WriteLine(sr.ReadToEnd());
            //}catch(FileNotFoundException ex2)
            //{
            //    Console.WriteLine(ex2.Message);
            //}
            try
            {
                arr = Read10strings();
            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.ReadLine();
        }
        public static string[] Read10strings()
        {
            int counter = 0;
            string[] arr = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter " +(i+1) + " string: " );
                arr[i] = Console.ReadLine();
                counter += arr[i].Length;
                if (counter >= 100)
                {
                    throw new ArgumentException("You have entered more then 100 characters!");
                }
            }
            return arr;
        }
    }
}
