using System;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            VoiceManager.PlayGreeting();
            AsciiArt.DisplayLogo();
            ChatBot bot = new ChatBot();
            bot.StartConversation();
        }
    }
}
