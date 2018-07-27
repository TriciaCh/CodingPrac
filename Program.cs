using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Program
    {
        //Given a sorted array and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //You may assume no duplicates in the array.


        public int SearchInsert(int[] nums, int target)
        {
            int len = nums.Length;
            int reval = 0;

            if (target < nums[0])
            {
                reval = 0;
            }
            if (target > nums[len - 1])
            {
                reval = len;
            }

            else
            {
                for (int i = 0; i < len; i++)
                {
                    if (nums[i] == target)
                    {
                        reval = i;
                    }

                    else if ((nums[i] < target && target < nums[i + 1] && i < len - 1))
                    {
                        reval = i + 1;
                    }
                
                }
            }
            return reval;
           
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 6 };
            int tg = 5;

            leetcode.Program a = new Program();
            int re = a.SearchInsert(array, tg);
            Console.WriteLine(re);
            Console.Read();
        }
    }
}




// Fastest solution from Leetcode below
//public class Solution
//{
//    public int SearchInsert(int[] nums, int target)
//    {
//        return BinarySearchHelper(nums, target, 0, nums.Length - 1);


//    }

//    public int BinarySearchHelper(int[] nums, int target, int leftIndex, int rightIndex)
//    {
//        int index = (leftIndex + rightIndex) / 2;
//        if (nums[index] == target)
//        {
//            return index;
//        }
//        else if (nums[index] < target)
//        {
//            leftIndex = index + 1;
//        }
//        else if (nums[index] > target)
//        {
//            rightIndex = index - 1;
//        }
//        if (leftIndex > rightIndex)
//        {
//            return leftIndex;
//        }
//        return BinarySearchHelper(nums, target, leftIndex, rightIndex);
//    }
//}
