using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_git2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("INPUT.TXT");

            string output = input;

            File.WriteAllText("OUTPUT.TXT" , output);
        }
    }
}
