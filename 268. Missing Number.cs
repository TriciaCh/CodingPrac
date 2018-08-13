using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268.Missing_Number
{
    class Program
    {
        //Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            int len = nums.Length;

            sum = (1 + len) * len / 2;

            var result = 0;

            for(int i = 0; i < len; i++)
            {
                result = sum - nums[i];
                sum = result;
            }

            return result;

        }

        static void Main(string[] args)
        {
        }
    }
}
