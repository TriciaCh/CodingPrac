using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    //  Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
    //  The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.
    //  You may assume the integer does not contain any leading zero, except the number 0 itself.
    // [1,2,3] + 1 => [1,2,4]
    class Program
    {
        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            //int[] reval = { };
            List<int> reval = new List<int>();
            int index = 0;

            if (digits[len - 1] < 9)
            {
                digits[len - 1]++;
                reval = digits.ToList();
            }

            else
            {
                var count = 0;
                foreach (var item in digits)
                {
                    if (item == 9)
                    {
                        count = count + 1;
                    }
                }
                if (count == len)
                {
                    reval.Add(1);
                    for (int i = 0; i < len; i++)
                    {
                        digits[i] = 0;
                        reval.Add(digits[i]);
                    }
                }


                else if (digits[len - 1] == 9)
                {
                    for (int i = len - 1; i >= 0; i--)
                    {
                        if (digits[i] == 9 && digits[i - 1] != 9 && (i - 1) >= 0 && index == 0)
                        {
                            index = i;
                        }

                    }
                    if (index > 0)
                    {
                        digits[index - 1] = digits[index - 1] + 1;

                        for (int i = index; i < len; i++)
                        {
                            digits[i] = 0;
                        }

                        reval = digits.ToList();

                    }
                }

            }

            return reval.ToArray();



        }



        static void Main(string[] args)
        {
            Program p = new Program();
            var arr = new int[] { 9, 7, 0, 1, 4, 1, 2, 8, 0, 2, 2, 3, 8, 1, 7, 2, 5, 0, 7, 8, 8 };
            var re = p.PlusOne(arr);
            Console.WriteLine(string.Join(",", re));
            Console.ReadLine();


        }
    }
}
