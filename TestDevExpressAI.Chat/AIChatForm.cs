using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;

namespace TestDevExpressAI
{
    public partial class AIChatForm : RibbonForm
    {
        public AIChatForm()
        {
            InitializeComponent();
            aiChatControl1.UseStreaming = DefaultBoolean.True;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }
}
