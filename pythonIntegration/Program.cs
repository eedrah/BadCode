using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonIntegration {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("I need to break out of this statically typed straight-jacket!!");

            string python = "print('What?!? Python is also strongly typed?!?')" + Environment.NewLine + 
                            "import subprocess " + Environment.NewLine + 
                            "output = subprocess.check_output(['node', '-p', 'console.log(\\'I hate you Javascript\\'); var exec = require(\\'child_process\\').exec;(function(){exec(\\'echo hi\\', function(err, stdout, stderr){console.log(stdout)}); return \\'\\';})()'])" + Environment.NewLine +
                            "print(output)";

            string output = new PythonCode().Run(python);

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
