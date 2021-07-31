using System;
using System.IO;
namespace algorithms
{
    class CreateData
    {
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