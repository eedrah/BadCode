using System;
using System.Diagnostics;

namespace pythonIntegration {
    public class BadCode {
        public string Run() {
            return "C# is so 1999..." + Environment.NewLine + Environment.NewLine + RunPython("print(\\\"What?!? Python is also strongly typed?!?\\n\\\")" + Environment.NewLine + "import subprocess " + Environment.NewLine + "output = subprocess.check_output([\\\"node\\\", \\\"-p\\\", \\\"console.log(\\\\\\\"Javascript. What have we done?\\\\\\\"); var exec = require(\\\\\\\"child_process\\\\\\\").exec;(function(){exec(\\\\\\\"ruby -e \\\\\\\\\\\\\\\"puts \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"Once more unto the breach, dear Ruby, once more...\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"\\\\\\\\\\\\\\\"\\\\\\\", function(err, stdout, stderr){console.log(stdout)}); return \\\\\\\"\\\\\\\";})()\\\"])" + Environment.NewLine + "print(output)");
        }

        public string RunPython(string code) {
            var process = new Process();
            process.StartInfo.FileName = @"C:\Program Files (x86)\IronPython 2.7\ipy64.exe";
            process.StartInfo.Arguments = string.Format("-c \"{0}\"", code);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            return output;
        }
    }
}