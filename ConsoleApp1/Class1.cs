using System;
using System.Numerics;

namespace Myspace
{
    internal class ListOfFive
    {
        private List<int> ints = new List<int>();
        public void AddToList(int number)
        {
            if (this.ints.Count() < 5)
            { this.ints.Add(number); }
            else
            {
                Console.WriteLine("list is overflowed");
            }
        }

        public override string? ToString()
        {
            string str = "";
            foreach (int n in ints)
            {
                str = str + n.ToString() + " ";
            }
            return str;
        }
        public int Sum()
        {
            if (ints.Count > 0)
            {
                int sum = 0;
                foreach (int n in ints)
                {
                    sum += n;
                }
                return sum;
            }
            return 0;
        }
        public string Min()
        {
            if(ints.Count > 0)
            {
                int min = int.MaxValue;
                foreach (int n in ints)
                {
                    if(n< min)
                    {
                        min = n;
                    }
                }
                return min.ToString();
            }
            return "NO numbers" ;
        }
        public string Max()
        {
            if (ints.Count > 0)
            {
                int max = int.MinValue;
                foreach (int n in ints)
                {
                    if(n> max)
                    {
                        max = n;
                    }
                }
                return max.ToString();
            }
            return "No numbers";
        }
        public string Product()
        {
            if (ints.Count > 0)
            {
                BigInteger product = 1;
                foreach(int n in ints)
                {
                    product *= n;
                }
                return product.ToString();
            }
            return "No numbers";

        }
    }

}