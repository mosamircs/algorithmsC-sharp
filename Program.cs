using System;
namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] list = {1,3,5,7,9,11,13,15,17};
            Search s1 = new Search();
            int? index = s1.BinarySearch(list,17);
            Console.WriteLine(index);
        }
    }
}
