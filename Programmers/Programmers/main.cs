using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programmers
{
    public class main
    {
        public static void Main(string[] args)
        {
            var m1 = new TagWords();
            var arr = new string[] {"hello", "o", "even", "never", "now", "world", "draw"};
            Console.WriteLine(m1.solution(2, arr)[0].ToString() +  m1.solution(2, arr)[1].ToString());
        }
    }
}
