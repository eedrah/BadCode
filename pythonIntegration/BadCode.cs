using System;

namespace pythonIntegration {
    public class BadCode {
        public string Run() {
            return "C# is so 1999..." + Environment.NewLine + Environment.NewLine + new PythonCode().Run("print(\\\"What?!? Python is also strongly typed?!?\\n\\\")" + Environment.NewLine + "import subprocess " + Environment.NewLine + "output = subprocess.check_output([\\\"node\\\", \\\"-p\\\", \\\"console.log(\\\\\\\"Javascript. What have we done?\\\\\\\"); var exec = require(\\\\\\\"child_process\\\\\\\").exec;(function(){exec(\\\\\\\"ruby -e \\\\\\\\\\\\\\\"puts \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"Once more unto the breach, dear Ruby, once more...\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"\\\\\\\\\\\\\\\"\\\\\\\", function(err, stdout, stderr){console.log(stdout)}); return \\\\\\\"\\\\\\\";})()\\\"])" + Environment.NewLine + "print(output)");
        }
    }
}