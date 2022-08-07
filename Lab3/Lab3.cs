/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Student Name                :  Amin Ahmadi                 **/
/**    EMail Address               :  ahma0160@algonquinlive.com  **/
/**    Student Number              :  040993411                   **/
/**    Course Number               :  CST 8253                    **/
/**    Lab Section Number          :  011                         **/
/**    Professor Name              :  Wei Gong                    **/
/**    Assignment Name/Number/Date :  Lab 3 2021/02/06            **/
/**    Optional Comments           :                              **/
/**                                                               **/
/**                                                               **/
/*******************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab3
    {
        static int[] intArray = {17,  166,  288,  324,  531,  792,  946,  157,  276,  441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227,
                                 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396,
                                 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784,
                                 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450,
                                 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150 };


        static void Main(string[] args)
        {
            Console.WriteLine("\n\nThe unsorted integer array : \n\n");
            PrintArray(intArray);

            int[] newArray = new int[intArray.Length];
            intArray.CopyTo(newArray, 0);

            int numOfSwaps = BubbleSort(newArray);

            Console.Write("\n\nThe sorted integer array : \n\n");
            PrintArray(newArray);
            Console.Write("\n\n");

            Console.Write("\n\nBubble sort made {0} swaps to sort the unsorted array \n\n", numOfSwaps);

            bool again = true;

            while (again)
            {
                Console.Write("Enter the targeted integer to search: ");
                int niddle = int.Parse(Console.ReadLine());
                int numOfComparison;

                int index = LinearSearch(intArray, niddle, out numOfComparison);
                Console.Write("\n\n_________________________________________________________________________________________________");
                Console.Write("\n\nResults:");
                if (index == -1)
                {
                    Console.Write("\n\n     Linear search: \n\n         {0} comparisons to find out that {1} is not in the unsorted array \n\n", numOfComparison, niddle);
                }
                else
                {
                    Console.Write("\n\n     Linear search: \n\n         {0} comparisons to find out that {1} is at index {2} in the unsorted array \n\n", numOfComparison, niddle, index);
                }

                int numOfComparisonBin;
                int binIndex = BinarySearch(newArray, niddle, out numOfComparisonBin);

                if (binIndex == -1)
                {
                    Console.Write("\n\n     Binary search: \n\n         {0} comparisons to find out that {1} is not in the sorted array \n", numOfComparisonBin, niddle);
                }
                else
                {
                    Console.Write("\n\n     Binary search: \n\n         {0} comparisons to find out that {1} is at index {2} in the sorted array \n", numOfComparisonBin, niddle, binIndex);
                }

                Console.Write("\n\nTRY AGAIN ? (type 'Y' to try again / Any other key to exit) ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Y":
                    case "y":
                        Console.Write("\n");
                        break;
                    default:
                        again = false;
                        break;
                }
            }

        }


    

        static int LinearSearch(int[] haystack, int niddle, out int numOfComparison)
        {
            numOfComparison = 0;
            int niddleIndex = -1;

            int totalElements = haystack.Count();
            for (int i = 0; i < totalElements; i++)
            {
                numOfComparison++;
                if (haystack[i] == niddle)
                {
                    niddleIndex = i;
                    break;
                }
            }


            return niddleIndex;
        }

        // used : https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash As a Source
        static int BubbleSort(int[] arr)
        {
            int numOfSwaps = 0;
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        numOfSwaps++;
                    }
                }
            }

            return numOfSwaps;
        }
        // used : https://www.tutorialspoint.com/Binary-search-in-Chash As a Source
        static int BinarySearch(int[] haystack, int niddle, out int numOfComparisonBin)
        {
            numOfComparisonBin = 0;
            int niddleIndex = -1;
            int minIndexNum = 0;
            int maxIndexNum = haystack.Length - 1;

            while (minIndexNum <= maxIndexNum)
            {
                numOfComparisonBin++;
                int mid = (minIndexNum + maxIndexNum) / 2;
                if (niddle == haystack[mid])
                {
                    niddleIndex = mid;
                    break;
                }
                else if (niddle < haystack[mid])
                {
                    maxIndexNum = mid - 1;
                }
                else
                {
                    minIndexNum = mid + 1;
                }  
            }

            return niddleIndex;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write("{0}, ", arr[i]);
                }
                else
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }

    }
}
