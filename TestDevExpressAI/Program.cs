using DevExpress.AIIntegration;
using Microsoft.Extensions.AI;
using OpenAI;

namespace TestDevExpressAI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var key = "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";

            DevExpressAIHelper.Initialize(key);            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}