using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Threading;


namespace AikonCWD_W10S_GUI.Logic
{
    public class CMD
    {
        /// <summary>
        /// Method that runs a command in W+R
        /// </summary>
        /// <param name="fn">Filename ex:cmd.exe</param>
        /// <param name="arg">Arguments</param>
        public static void RunCmdCommand(string fn, string arg)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = fn;
            startInfo.Arguments = arg;
            process.StartInfo = startInfo;
            process.Start();
        }

        /// <summary>
        /// Method that runs a powershell command
        /// </summary>
        /// <param name="args">Arguments</param>
        public static void RunPowershellCommand(string args)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddScript(args);
                PowerShellInstance.Invoke();
            }
        }
    }
}
