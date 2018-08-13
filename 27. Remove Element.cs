using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Remove_Element
{
    class Program
    {
        //  Given an array nums and a value val, remove all instances of that value in-place and return the new length.
        //  Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        //  The order of elements can be changed. It doesn't matter what you leave beyond the new length.


        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            int result = 0;

            if (len == 0) result = len;

            else
            {
                for (int i = 0; i < len; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[result] = nums[i];
                        result++;
                    }

                }

            }
            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
