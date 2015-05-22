using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonIntegration {
    class Program {
        static void Main(string[] args)
        {
            string python = "import subprocess " + Environment.NewLine + 
                            "output = subprocess.check_output(['node', '-p', '(function(){return \\'this is ridiculous\\'})()'])" + Environment.NewLine +
                            "print(output)";

            string output = new PythonCode().Run(python);

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
