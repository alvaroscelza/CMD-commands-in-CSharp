using CMDInCSharp;
using System;
using System.Threading;

namespace ChangeIPRemotelyWithCMD
{
    class Program
    {
        private static readonly string pcName = "machineName";
        private static readonly string connectionInterfaceName = "\"Local Area Connection\"";

        static void Main(string[] args)
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);
            var timer = new Timer((e) =>
            {
                changeRemoteIP();
            }, null, startTimeSpan, periodTimeSpan);
        }

        private static void changeRemoteIP()
        {
            string commandToChangeRemoteIPToDynamic = string.Format(
                "psexec.exe \\{0} netsh interface ip set address name={1} source=dhcp",
                pcName, connectionInterfaceName);
            CMDExecutor executor = new CMDExecutor();
            executor.SilentylExecuteCommandInCMD(commandToChangeRemoteIPToDynamic);
        }
    }
}
