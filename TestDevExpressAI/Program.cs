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