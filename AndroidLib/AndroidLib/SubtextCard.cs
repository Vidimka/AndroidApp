using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;

using static AndroidLib.Util;

namespace AndroidLib
{
    public class SubtextCard : BasicCard
    {
        TextView textField;
        public SubtextCard(Context? context, int imageId) : base(context, imageId)
        {
            base.Initialize(imageId); //Is this even a way?
            //Initialize();
        }

        void Initialize()
        {
            titleField = new TextView(Context);
            titleField.Id = View.GenerateViewId();
            textField = new TextView(Context);
            textField.Id = View.GenerateViewId();

            textField.SetTextColor(Color.DimGray);
            textField.SetTextSize(ComplexUnitType.Dip, 14);
            var textLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(18));
            textLp.SetMargins(0, DpToPx(10), 0, DpToPx(10));
            textLp.AddRule(LayoutRules.Below, titleField.Id);
            textField.LayoutParameters = textLp;

            AddView(textField);
        }

        public void AddText(string text) => textField.Text = text;
    }
}
