using System;
using System.IO;
namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateData();
            //reads the list
            Console.WriteLine("Enter the list of elements separated by spaces: ");
            int [] list = Array.ConvertAll(Console.ReadLine().Split(' '),temp =>Convert.ToInt32(temp ));

            //reads the element to search in the list
            Console.WriteLine("Enter the element to search for: ");
            int element =Convert.ToInt32(Console.ReadLine());
            
            //reads search algorithm choice
            Console.WriteLine("Enter Search Algorithm (linear or binary): " );
            string seachChoice = Console.ReadLine();
            
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Switch.SwitchSearch(seachChoice, list,element);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");    

        }
    }
}
