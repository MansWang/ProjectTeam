using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sorting
{
    class Program
    {

        public static void Main(string[] args)
        {
            //    int[] myarray = new int[5];
            //    Console.WriteLine("Bubble Sort Please Input 5 numbers: ");
            //    string input = Console.ReadLine();
            //    int x = Convert.ToInt32(input);

            //    for (int i = 0; i < myarray.Length; i++)
            //    {
            //        string input2 = Console.ReadLine();
            //        myarray[i] = Convert.ToInt32(input2);
            //    }


            //    Forwardbubblesort(myarray);

            //    Console.WriteLine();

            //    for (int i = 0; i < myarray.Length; i++)
            //    {
            //        Console.WriteLine(myarray[i] + " ");
            //    }
            //    Console.ReadLine();

            //}
            //static void Forwardbubblesort(int[] array)
            //{
            //    int[] arr1 = new int[5];
            //    arr1 = array;
            //    int x;
            //    for (int pass = 0;pass < arr1.Length; pass++)
            //    {

            //        for (int i = 0; i < arr1.Length - 1; i++)
            //        {
            //            //Console.WriteLine(array1[i]); 
            //            if (arr1[i] > arr1[i + 1])
            //            {
            //                x = arr1[i + 1];
            //                arr1[i + 1] = arr1[i];
            //                arr1[i] = x;
            //            }
            //        }
            //    }
            
                
                int[] myarray = new int[5];

                Console.WriteLine("Bubble Sort Please Input 5 numbers: ");

           
                for (int i = 0; i < myarray.Length; i++) //it was  myarray.Length-1
                {
                    string input2 = Console.ReadLine();
                    myarray[i] = Convert.ToInt32(input2);
                    //Console.WriteLine(myarray[i]);
                }
               
                Forwardbubblesort(myarray);
                Console.WriteLine();

                for (int i = 0; i < myarray.Length; i++)
                {
                    Console.WriteLine(myarray[i] + " ");
                }


                Reversebubblesort(myarray);
                Console.WriteLine();

                for (int i = 0; i < myarray.Length; i++)
                {
                    Console.WriteLine(myarray[i] + " ");
                }


           

        }
        static void Forwardbubblesort(int[] array)
        {
            int[] arr1 = new int[5];
            arr1 = array;
            int x;
            for (int pass = 0; pass < arr1.Length; pass++)
            {

                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    //Console.WriteLine(array1[i]); 
                    if (arr1[i] > arr1[i + 1])
                    {
                        x = arr1[i + 1];
                        arr1[i + 1] = arr1[i];
                        arr1[i] = x;
                    }
                }
            }


        }
        static void Reversebubblesort(int[] array1)
        {
            int[] arr1 = new int[5];
            arr1 = array1;
            int x;
            for (int pass = 0; pass < arr1.Length; pass++)
            {

                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    //Console.WriteLine(array1[i]); 
                    if (arr1[i] < arr1[i + 1])
                    {
                        x = arr1[i + 1];
                        arr1[i + 1] = arr1[i];
                        arr1[i] = x;
                    }
                }
            }
        }
        
    }
}





