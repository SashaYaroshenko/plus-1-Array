using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.UpArray(new int[] { 0, 7, 4 });
        }
    }

    public static class Kata
    {
        public static int[] UpArray(int[] num)
        {
            if (num == null)
            {
                return null;
            }
            if (num.Length == 0)
            {
                return null;
            }
            if (num.Any(x => x < 0) == true)
            {
                return null;
            }
            if (num.Any(x => x > 9) == true)
            {
                return null;
            }

            num[num.Length - 1] += 1;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == 10)
                {
                    num[i] = 0;
                    if (i != 0)
                    {
                        num[i - 1] += 1;
                    }
                    else
                    {
                        List<int> list = num.ToList();
                        list.Add(1);
                        list.Reverse();
                        num = list.ToArray();
                    }
                }
                else
                {
                    break;
                }
            }

            return num;
        }
    }
}
