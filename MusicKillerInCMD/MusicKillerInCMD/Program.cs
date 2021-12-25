using CMDInCSharp;

namespace MusicKillerInCMD
{
    class Program
    {
        private static string commandToKillWindowsMediaPlayer = "TaskKill.exe /IM WMPlayer.exe";
        private static string commandToStopAudioService = "Net Stop Audiosrv";

        static void Main(string[] args)
        {
            CMDExecutor.SilentylExecuteCommandInCMD(commandToKillWindowsMediaPlayer);

            //following process requires admin privileges, if a user got his UAC so as to avoid asking admin prompts, the audio 
            //service will stop without asking him anything. Otherwise it won't do anything.
            CMDExecutor.SilentylExecuteCommandInCMD(commandToStopAudioService);
        }
    }
}
