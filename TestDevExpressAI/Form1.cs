using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
//using TestDevExpressAI.Chat;

namespace TestDevExpressAI
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            behaviorManager.AddAIBehaviors(memoEdit1);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChatService.ShowChatForm();
        }
    }
}
