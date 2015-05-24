using System;
using System.Diagnostics;

namespace pythonIntegration {
    public class BadCode {
        public string Run() {
            var pythonProcess = new Process { StartInfo = { FileName = "C:\\Program Files (x86)\\IronPython 2.7\\ipy64.exe", Arguments = string.Format("-c \"{0}\"", "print(\\\"What?!? Python is also strongly typed?!?\\n\\\")" + Environment.NewLine + "import subprocess " + Environment.NewLine + "output = subprocess.check_output([\\\"node\\\", \\\"-p\\\", \\\"console.log(\\\\\\\"Javascript. What have we done?\\\\\\\"); var exec = require(\\\\\\\"child_process\\\\\\\").exec;(function(){exec(\\\\\\\"ruby -e \\\\\\\\\\\\\\\"puts \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"Once more unto the breach, dear Ruby, once more...\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"\\\\\\\\\\\\\\\"\\\\\\\", function(err, stdout, stderr){console.log(stdout)}); return \\\\\\\"\\\\\\\";})()\\\"])" + Environment.NewLine + "print(output)"), UseShellExecute = false, RedirectStandardOutput = true } }; pythonProcess.Start(); pythonProcess.WaitForExit(); return "C# is so 1999..." + Environment.NewLine + Environment.NewLine + pythonProcess.StandardOutput.ReadToEnd();
        }
    }
}