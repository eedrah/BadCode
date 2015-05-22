using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonIntegration {
    class PythonCode {
        public string Run(string code) {
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
