using System.Diagnostics;

namespace CMDInCSharp
{
    public class CMDExecutor
    {
        private static readonly string cmdOptionToExecuteCommandAndEnd = "/c ";

        public void SilentylExecuteCommandInCMD(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = cmdOptionToExecuteCommandAndEnd + command
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }
    }
}
