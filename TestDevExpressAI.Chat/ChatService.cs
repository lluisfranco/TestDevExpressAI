namespace TestDevExpressAI.Chat
{
    public class ChatService
    {
        public static void ShowChatForm()
        {
            var chatForm = new AIChatForm();
            chatForm.ShowDialog();
        }
    }
}
