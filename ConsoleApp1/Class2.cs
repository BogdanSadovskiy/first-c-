using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReversNumber
    {
        private struct sturcture{
                 int number;
                 int n;
        }
        private List<sturcture> list = new List<sturcture>();
        private int SizeOFNumber(int number)
        {
            int n = 1;
            int tmp = number;
            while(tmp!= 0)
            {
                tmp /= 10;
                n++;
            }
            return 1;
        }
        public addNumber(int number)
        {
            
        }

    }
}
