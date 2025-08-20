using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace TestDevExpressAI
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            var filename = @"G:\Zoo\IT\OpenAIAPITText.txt";
            if (File.Exists(filename))
            {
                var content = File.ReadAllText(filename);
                DevExpressAIHelper.Initialize(content);
            }
            behaviorManager.AddAIBehaviors(memoEdit1);
        }
    }
}
