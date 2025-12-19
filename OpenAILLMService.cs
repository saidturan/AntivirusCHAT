using System.Threading.Tasks;

namespace LLMAntivirusChatbot
{
    public class OpenAILLMService
    {
        public async Task<string> AnalyzeWithLLM(string userInput)
        {
            await Task.Delay(500); // LLM düşünüyormuş gibi

            if (userInput.ToLower().Contains("registry") ||
                userInput.ToLower().Contains("powershell") ||
                userInput.ToLower().Contains("autorun"))
            {
                return
@"Threat Analysis (LLM Simulation):

Risk Level: MALICIOUS

Explanation:
The behavior shows persistence and scripting techniques commonly used by malware.

Recommendation:
• Isolate the file
• Do not execute
• Run antivirus scan";
            }

            return
@"Threat Analysis (LLM Simulation):

Risk Level: SAFE

Explanation:
No known malicious patterns detected.

Recommendation:
• No action required";
        }
    }
}

