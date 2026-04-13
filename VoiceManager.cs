using System;
using System.Media;
namespace CyberSecurityAwarenessBot
{
    public static class VoiceManager
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Voice greeting could not be played: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
