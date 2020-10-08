using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aaab : " + IsAbeforeB("aaab"));
            Console.WriteLine("ba : " + IsAbeforeB("ba"));
            Console.WriteLine("aaa : " + IsAbeforeB("aaa"));
            Console.WriteLine("b : " + IsAbeforeB("b"));
            Console.WriteLine("abba : " + IsAbeforeB("abba"));
            Console.WriteLine("baa : " + IsAbeforeB("baa"));
            Console.ReadLine();
        }

        private static bool IsAbeforeB(string str)
        {
            return (str.IndexOf("a") < 0 || str.IndexOf("b") < 0 || !str.Contains("ba"));
        }
    }
}
