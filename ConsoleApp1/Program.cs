using System.Net.Http.Headers;

namespace Myspace { 
    class program
    {
        static void Main(string[] args)
        {
            
            //first and second exercises
            //    ListOfFive newList = new ListOfFive();
            //    while (true)
            //    {
            //        Console.WriteLine("Input number");
            //        try
            //        {
            //            string str = Console.ReadLine();
            //            if (str != null)
            //            {
            //                if (str == "e")
            //                {
            //                    break;
            //                }
            //                int number = int.Parse(str);
            //                newList.AddToList(number);
            //            }
            //        }
            //        catch(FormatException e)
            //        {
            //            Console.WriteLine(e);
            //        }
            //    }

            //    Console.WriteLine(newList.ToString());
            //    Console.WriteLine("SUM = " + newList.Sum());
            //    Console.WriteLine("Min = " + newList.Min());
            //    Console.WriteLine("Max = " + newList.Max());
            //    Console.WriteLine("Product = " + newList.Product());
            //

            //third exercise
            ReversNumber reverse = new ReversNumber();
            while (true)
            {
                Console.WriteLine("Input number");
                string str = Console.ReadLine();
                if (str != null)
                {
                    if (str == "e")
                    {
                        break;
                    }
                    int number = int.Parse(str);

                    Console.WriteLine(reverse.reversNumber(number));
                }

            }
        }
    }

}

