using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myspace
{
    internal class ReversNumber
    {
        private int SizeOFNumber(int number)
        {
            int n = 1;
            int tmp = number;
            while(tmp!= 0)
            {
                tmp /= 10;
                n++;
            }
            return n;
        }
        public int reversNumber(int number)
        {
            int size = SizeOFNumber(number);
            int tmp = number;
            int reversNumberTmp = 0;

            for(int i = 0; i < size;i++)
            {
                int t = tmp % 10;
                for(int ii = size - i-1; ii>1;ii--)
                {
                    t *= 10;
                }
                reversNumberTmp += t;
                tmp /= 10;
            }
            return reversNumberTmp;
        }

    }
}
