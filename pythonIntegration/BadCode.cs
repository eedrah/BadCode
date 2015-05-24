using System;

namespace pythonIntegration {
    public class BadCode {
        public string Run() {
            string cSharp = "C# is so 1999...";

            string python = "print(\\\"What?!? Python is also strongly typed?!?\\n\\\")" + Environment.NewLine +
                            "import subprocess " + Environment.NewLine +
                            "output = subprocess.check_output([\\\"node\\\", \\\"-p\\\", \\\"console.log(\\\\\\\"Javascript. What have we done?\\\\\\\"); var exec = require(\\\\\\\"child_process\\\\\\\").exec;(function(){exec(\\\\\\\"echo Once more unto the breach, dear Ruby, once more...\\\\\\\", function(err, stdout, stderr){console.log(stdout)}); return \\\\\\\"\\\\\\\";})()\\\"])" + Environment.NewLine +
                            "print(output)";

            return cSharp + Environment.NewLine + Environment.NewLine + new PythonCode().Run(python);
        }
    }
}