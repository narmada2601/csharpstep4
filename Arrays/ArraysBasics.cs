using System;

namespace step4.Arrays
{
     class ArraysBasics
    {
        public static void Main()
        {
            //arrays:collection of similar datatypes......
            int[] id = { 1, 2, 3, 4 };//declare an array
            int[] index = new int[2];
            index[0] = 1;
            index[1] = 2;
            index[2] = 3;//throws an indexoutofboundexception
            //2.Array with fixed size
            int[] arr1 = new int[3];
            arr1[1]= 10;
            arr1[2] = 20;
            arr1[3] = 30;//4 throws exception

            //3.No Boxing
            int third = arr1[0];


            //4.Multidata Types not possible
            int[] arr2 = new int[2];
            //arr2[0] = false;
            //arr2[1] = "Hello";

            //5.Looping
            int[] arr3 = new int[4];
            arr3[0] = 10;
            arr3[1] = 20;
            arr3[2] = 30;
            arr3[3] = 40;

            foreach (int x in arr3)
            {
                Console.WriteLine(x);
            }
        }
    }
}
