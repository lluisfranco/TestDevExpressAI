using DevExpress.AIIntegration;
using DevExpress.AIIntegration.WinForms;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using Microsoft.Extensions.AI;
using OpenAI;
using System.Globalization;

namespace TestDevExpressAI
{
    internal static class DevExpressAIHelper
    {
        public static IEnumerable<string> SupportedTranslationLanguages => ["en", "ca", "es", "fr", "ru", "de", "zh-Hans", "ja"];

        public static void Initialize(string key, string model = "gpt-4o")
        {
            IChatClient openAIChatClient = new OpenAIClient(key).GetChatClient(model).AsIChatClient();
            AIExtensionsContainerDesktop.Default.RegisterChatClient(openAIChatClient);
        }

        public static void AddAIBehaviors(this BehaviorManager behaviorManager, MemoEdit editor)
        {
            behaviorManager.SetBehaviors(editor,
            [
                ExpandBehavior.Create(typeof(MemoEditExpandBehaviorSource)),
                SummarizeBehavior.Create(typeof(MemoEditSummarizeBehaviorSource), SummarizationMode.Abstractive),
                ChangeToneBehavior.Create(typeof(MemoEditChangeToneBehaviorSource)),
                ChangeStyleBehavior.Create(typeof(MemoEditChangeStyleBehaviorSource)),
                ShortenBehavior.Create(typeof(MemoEditShortenBehaviorSource)),
                ExplainBehavior.Create(typeof(MemoEditExplainBehaviorSource)),
                ProofreadBehavior.Create(typeof(MemoEditProofreadBehaviorSource)),
                TranslateBehavior.Create(typeof(MemoEditTranslateBehaviorSource), [.. GetSupportedLanguagesList()]),
                CustomRequestBehavior.Create(typeof(MemoEditCustomRequestBehaviorSource)),
                SmartAutoCompleteBehavior.Create(typeof(SmartAutoCompleteBehaviorSource), 500, null)
            ]);
        }

        public static void AddAIBehaviors(this BehaviorManager behaviorManager, RichEditControl editor)
        {
            behaviorManager.SetBehaviors(editor,
                [
                ExpandBehavior.Create(typeof(RichEditExpandBehaviorSource)),
                SummarizeBehavior.Create(typeof(RichEditSummarizeBehaviorSource), SummarizationMode.Abstractive),
                ChangeToneBehavior.Create(typeof(RichEditChangeToneBehaviorSource)),
                ChangeStyleBehavior.Create(typeof(RichEditChangeStyleBehaviorSource)),
                ShortenBehavior.Create(typeof(RichEditShortenBehaviorSource)),
                ExplainBehavior.Create(typeof(RichEditExplainBehaviorSource)),
                ProofreadBehavior.Create(typeof(RichEditProofreadBehaviorSource)),
                TranslateBehavior.Create(typeof(RichEditTranslateBehaviorSource), [.. GetSupportedLanguagesList()]),
                CustomRequestBehavior.Create(typeof(RichEditCustomRequestBehaviorSource)),
                SmartAutoCompleteBehavior.Create(typeof(SmartAutoCompleteBehaviorSource), 500, null)
            ]);
        }

        private static IEnumerable<LanguageInfo> GetSupportedLanguagesList()
        {
            return SupportedTranslationLanguages.Select(language =>
            {
                var culture = new CultureInfo(language);
                return new LanguageInfo
                {
                    Culture = culture,
                    LanguageName = culture.DisplayName
                };
            });
        }
    }
}
