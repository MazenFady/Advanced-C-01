    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    namespace Demo
    {
        public class Program
        {
            public static void Main() 
            {
                int[] arr = { 55, 66, 98, 35, 20, 10, 5, 45, 69 };
                Sort.TheBubbleSort(arr);
                Console.WriteLine($"the sort array : {string.Join (",",arr)}");
            Console.ReadKey();
            }
            static class Sort
            {
               public static void TheBubbleSort<T>(T[] array ) where T : IComparable<T> 
                {

                    int n = array.Length;
                    bool swapped;

                    for (int i = 0; i < n; i++)
                    {
                        swapped = false;
                        for (int j = 0; j < n - i -1; j++)
                        {
                            if (array[j].CompareTo(array[j + 1])>0) 
                            {
                                T temp = array[j];
                                array[j]= array[j + 1];
                                array[j+1]= temp;
                        
                                swapped = true;
                            }
                        }
                        if (!swapped)
                            break;

                    }

                }

            }



        }



    }