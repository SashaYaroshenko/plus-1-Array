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

                string res = "";
                for(int i = 0; i < num.Length; i++)
                {
                    res += num[i];
                }
                int res1 = Convert.ToInt32(res);
                res1 = res1 + 1;
                char[] chars = res1.ToString().ToCharArray();
                int[] Achars = new int[chars.Length];
                for (int i = 0; i < chars.Length; i++)
                {
                    Achars[i] = Convert.ToInt32(chars[i].ToString());
                }
                return Achars;
            }
        }
    
}
