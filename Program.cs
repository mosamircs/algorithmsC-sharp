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
            SwitchSearch(seachChoice, list,element);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");    

        }
        public static void SwitchSearch(string searchChoice,int [] list,int element)
        {
            Search obj = new Search();
            switch(searchChoice)
            {
                case "linear":
                {
                    int? index = obj.LinearSearch(list,element);
                    Console.WriteLine(index);
                    break;
                }
                case "binary":
                {
                    int? index = obj.BinarySearch(list,element);
                    Console.WriteLine(index);
                    break;
                }
            }
        }
        public static void CreateData()
        { 
             //Random r = new Random(); 
             int number = 0; 
             using (StreamWriter writer = File.AppendText(@"d:\\algorithms\testfilebinary.txt"))
             {
                 for (int i = 1; i < 1000; i++)
                 {
                     writer.Write(i + " ");
                 }
                 writer.WriteLine();
                writer.Write(959);
                writer.WriteLine();
                writer.Write("binary");
             }
          }
    }
}
