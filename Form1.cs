namespace LLMAntivirusChatbot
{
    public partial class Form1 : Form
    {
        AntivirusAnalyzer analyzer = new AntivirusAnalyzer();
        LLMResponseGenerator llm = new LLMResponseGenerator();
        OpenAILLMService openAi;



        public Form1()
        {
            InitializeComponent();
            openAi = new OpenAILLMService();

        }

        private async void btnSend_Click(object sender, EventArgs e)

        {
            string userMessage = txtUserInput.Text.Trim();

            if (string.IsNullOrEmpty(userMessage))
                return;

            rtbChat.AppendText("Kullanýcý: " + userMessage + Environment.NewLine);

            string risk = analyzer.Analyze(userMessage);
            string botResponse = llm.GenerateResponse(userMessage, risk);


            rtbChat.AppendText("Bot: " + botResponse + Environment.NewLine + Environment.NewLine);

            txtUserInput.Clear();
        }
    }
}
