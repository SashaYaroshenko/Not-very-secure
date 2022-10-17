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
        }
    }

    public class Kata
    {
        public static bool Alphanumeric(string str)
        {
            bool flag = true;
            foreach(char i in str)
            {
                if(Char.IsLetterOrDigit(i))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
