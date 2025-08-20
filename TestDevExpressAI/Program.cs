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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}