using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonIntegration {
    class Program {
        static void Main(string[] args)
        {
            string python = "print('hello world')";

            string output = new PythonCode().Run(python);

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
