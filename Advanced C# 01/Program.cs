using System;
namespace Demo
{
    public class Program
    {
        //#region Sort


        //public static void Main()
        //{
        //    int[] arr = { 55, 66, 98, 35, 20, 10, 5, 45, 69 };
        //    Sort.TheBubbleSort(arr);
        //    Console.WriteLine($"the sort array : {string.Join(",", arr)}");
        //    Console.ReadKey();
        //}
        //static class Sort
        //{
        //    public static void TheBubbleSort<T>(T[] array) where T : IComparable<T>
        //    {

        //        int n = array.Length;
        //        bool swapped;

        //        for (int i = 0; i < n; i++)
        //        {
        //            swapped = false;
        //            for (int j = 0; j < n - i - 1; j++)
        //            {
        //                if (array[j].CompareTo(array[j + 1]) > 0)
        //                {
        //                    T temp = array[j];
        //                    array[j] = array[j + 1];
        //                    array[j + 1] = temp;

        //                    swapped = true;
        //                }
        //            }
        //            if (!swapped)
        //                break;

        //        }

        //    }

        //}
        //#endregion

        #region GenericRange
        public static void Main()
        {
            var inRange = new Range<int>(10,30);
            Console.WriteLine($"in range : {inRange.IsInRange(10)}");
            
        }
        public class Range<T> where T : IComparable<T>
        {
            public T Min { get; set; }
            public T Max { get; set; }
            public  Range(T min , T max)
            {
                if (min.CompareTo(max) > 0) 
                {
                   throw new ArgumentException("min must be less than max");
                  
                }
                Min = min;
                Max = max;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(Min) >= 0&&  value.CompareTo(Max) <= 0; 

            }
            public dynamic Length() 
            {
                return (dynamic)Max - (dynamic)Min;

            }
        }
        

        #endregion

    }



}