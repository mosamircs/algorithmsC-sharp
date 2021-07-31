using System;
using System.IO;
namespace algorithms
{
    class Switch
    {
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
    }
}