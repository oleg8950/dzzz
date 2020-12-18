using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "How are you?";
    
            File.WriteAllText(@"C:\Users\User\Desktop/textfile", text);

            Console.WriteLine(Text was written)
            Console.ReadKey();
        }
    }
}
