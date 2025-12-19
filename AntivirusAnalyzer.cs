using System.Collections.Generic;
using System.Linq;

namespace LLMAntivirusChatbot
{
    public class AntivirusAnalyzer
    {
        private List<string> maliciousKeywords = new List<string>()
        {
            "keylogger",
            "ransomware",
            "encrypt",
            "registry",
            "autorun",
            "powershell -enc",
            "cmd /c",
            "backdoor",
            "trojan"
        };

        private List<string> suspiciousKeywords = new List<string>()
        {
            ".exe",
            ".bat",
            ".ps1",
            "download",
            "script",
            "macro"
        };

        public string Analyze(string input)
        {
            input = input.ToLower();

            if (maliciousKeywords.Any(k => input.Contains(k)))
                return "MALICIOUS";

            if (suspiciousKeywords.Any(k => input.Contains(k)))
                return "SUSPICIOUS";

            return "SAFE";
        }
    }
}
