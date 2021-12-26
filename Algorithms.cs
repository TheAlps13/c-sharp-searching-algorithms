using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithms
{
    class Algorithms
    {
        public static int BinarySearch(List<int> input, int searchVal)
        {
            input.Sort(); // Sort the list first
            int high = input.Count - 1; 
            int mid = input.Count / 2; 
            int low = 0;

            //Check if the first element of the array matches our search val
            if (input[0] == searchVal)
                return 0;

            while(high - low > 1)
            {
                if (searchVal > input[mid])
                {
                    low = mid;
                    mid = (high + low) / 2 + 1;
                }

                if (searchVal < input[mid])
                {
                    high = mid;
                    mid = (high + low) / 2;
                }

                if (searchVal == input[mid])
                    return mid;
            }
         
            return -1; // If the value we are searching for isnt found return -1
        }
    }
}
