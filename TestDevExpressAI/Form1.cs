using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.IO;
//using TestDevExpressAI.Chat;

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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChatService.ShowChatForm();
        }
    }
}
