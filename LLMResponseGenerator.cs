using System.Text;

namespace LLMAntivirusChatbot
{
    public class LLMResponseGenerator
    {
        public string GenerateResponse(string input, string risk)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Risk Seviyesi: {risk}");
            sb.AppendLine();

            if (risk == "SAFE")
            {
                sb.AppendLine("Bu girdi güvenli görünüyor.");
                sb.AppendLine("Zararlı bir davranış tespit edilmedi.");
            }
            else if (risk == "SUSPICIOUS")
            {
                sb.AppendLine("Bu girdi şüpheli öğeler içeriyor.");
                sb.AppendLine("Sistemde beklenmeyen davranışlara yol açabilir.");
            }
            else if (risk == "MALICIOUS")
            {
                sb.AppendLine("⚠️ DİKKAT: Zararlı davranış tespit edildi.");
                sb.AppendLine();
                sb.AppendLine("Olası tehditler:");
                sb.AppendLine("- Yetkisiz sistem değişiklikleri");
                sb.AppendLine("- Kalıcılık (registry, startup)");
                sb.AppendLine("- Komut çalıştırma veya payload indirme");
                sb.AppendLine();
                sb.AppendLine("Öneri:");
                sb.AppendLine("Bu komutu çalıştırmayın ve güvenlik uzmanına danışın.");
            }

            return sb.ToString();
        }
    }
}
