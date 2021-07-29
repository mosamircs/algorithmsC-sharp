using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the list of elements separated by spaces: ");
            int [] list = Array.ConvertAll(Console.ReadLine().Split(' '),temp =>Convert.ToInt32(temp ));
            Console.WriteLine("Enter the element to search for: ");
            int element =Convert.ToInt32(Console.ReadLine());
            Search s1 = new Search();
            int? index = s1.BinarySearch(list,element);
            Console.WriteLine(index);
        }
    }
}
