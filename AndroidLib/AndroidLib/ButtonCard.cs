using Android.Content;
using Android.Views;

using static AndroidLib.Util;

namespace AndroidLib
{
    public class ButtonCard : SubtextCard
    {
        Button button;
        public ButtonCard(Context? context, int imageId) : base(context, imageId)
        {
            base.Initialize(imageId);
            Initialize();
        }

        void Initialize()
        {
            titleField.Id = View.GenerateViewId();
            textField.Id = View.GenerateViewId();
            button = new CustomButton(Context);

            SetClipToPadding(false);

            var buttonLp = new LayoutParams(LayoutParams.MatchParent, DpToPx(55));
            buttonLp.AddRule(LayoutRules.Below, textField.Id);
            buttonLp.SetMargins(0, DpToPx(10), 0, DpToPx(8));
            button.LayoutParameters = buttonLp;

            AddView(button);
        }
    }
}
