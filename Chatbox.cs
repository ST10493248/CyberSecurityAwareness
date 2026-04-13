using System;

namespace CyberSecurityAwarenessBot
{
    public class ChatBot
    {
        private string userName;

        public void StartConversation()
        {
            AskUserName();
            RunChatLoop();
        }

        private void AskUserName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
                userName = "Guest";

            Console.WriteLine($"\nHello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            Console.WriteLine("Ask me about passwords, phishing, or safe browsing.\n");
            Console.ResetColor();
        }

        private void RunChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                string input = Console.ReadLine()?.Trim().ToLower();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                if (input == "exit" || input == "quit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    return;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            switch (input)
            {
                case "how are you":
                    Console.WriteLine("Bot: I’m just code, but I’m running smoothly!");
                    break;

                case "what's your purpose":
                    Console.WriteLine("Bot: My purpose is to teach you about online safety.");
                    break;

                case "what can i ask you about":
                    Console.WriteLine("Bot: You can ask me about password safety, phishing, and safe browsing.");
                    break;

                case "password safety":
                    Console.WriteLine("Bot: Use long, unique passwords and enable two-factor authentication.");
                    break;

                case "phishing":
                    Console.WriteLine("Bot: Be cautious of emails asking for personal info. Check sender addresses carefully.");
                    break;

                case "safe browsing":
                    Console.WriteLine("Bot: Avoid clicking suspicious links and keep your browser updated.");
                    break;

                default:
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                    break;
            }

            UIHelper.SimulateTyping("Bot: Remember — cybersecurity is everyone’s responsibility!");
        }
    }
}
