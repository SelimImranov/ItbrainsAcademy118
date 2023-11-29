using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend118_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] arr = { 5, 3, 6, 91, 24, 103, 78, 63 };
            //int max = arr[0];
            ////foreach (int i in arr)
            ////{
            ////    if (i % 2 == 1)
            ////    {
            ////        Console.WriteLine(i);
            ////    }


            ////}
            ////for(var i= 0; i < arr.Length;i++) {
            ////    if (arr[i] >max)
            ////    {
            ////        max = arr[i];
            ////    }

            ////}
            ////Console.WriteLine(max);
            //int sum = 0;
            //foreach (var item in arr) { 
            //    sum += item;
                


            //}
            //Console.WriteLine(sum);
            #endregion
            //int count = 0;
            int[] array = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            //foreach (var item in array) {
            //    if (item == 5)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            //int cem = 0;
            //foreach (var item in array) { 
            //    cem += item;


            //}
            //Console.WriteLine(cem);
            //int count = 0;
            //int maxnum = array[0];
            //for(var i=0; i<array.Length; i++)
            //{
            //    if(maxnum <array[i])
            //    {
            //        maxnum= array[i];
            //    }
            //    if (array[i] == 7)
            //    {
            //        count++;


            //    }
            //}
            //Console.WriteLine(maxnum);
            //Console.WriteLine(count);
            //int x = 0;
            //for(int i = 0; i<array.Length; i++)
            //{
            //    if (array[i]%3==2)
            //    {
            //        Console.WriteLine(array[i]);
            //        x++;

            //    }
            //    if (x == 3)
            //    {
            //        break;
            //    }
         
            //}
            int first = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 7)
                {
                    Console.WriteLine(first);
                }
            }



        }


        #region methodlar
        public static void hellomethod()
        {
            Console.WriteLine("hello world");

        }
        #endregion

    }
}