using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    class Program

    {

        //Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

        //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        public int RemoveDuplicates(int[] nums)
        {
            var len = nums.Length;

            var newLen = 0;

            if (len <= 1) { newLen = len; }
            else
            {
                newLen = 1;

                for (int i = 1; i < len; i++)
                {

                    if (nums[i] > nums[i - 1])
                    {
                        nums[newLen] = nums[i]; 
                        newLen++;
                    }

                }
            }
            return newLen;



        }

        static void Main(string[] args)
        {
        }
    }
}
