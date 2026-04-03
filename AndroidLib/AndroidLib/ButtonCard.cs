using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;

using static AndroidLib.Util;

namespace AndroidLib
{
    public class ButtonCard : BasicCard
    {
        TextView titleField;
        TextView textField;
        Button button;
        ImageView image;

        static int radiusValue = DpToPx(24);
        static float[] outerRadii = { radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue };
        static RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
        ShapeDrawable backgroundShape = new ShapeDrawable(roundRect);
        public ButtonCard(Context? context, int imageId) : base(context, imageId)
        {
            base.Initialize(imageId); //Is this even a way?
            Initialize(imageId);
        }

        void Initialize(int imageId)
        {
            titleField = new TextView(Context);
            titleField.Id = View.GenerateViewId();
            textField = new TextView(Context);
            textField.Id = View.GenerateViewId();
            button = new CustomButton(Context);
            image = new ImageView(Context);
            image.SetImageResource(imageId);

            Elevation = DpToPx(50);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            LayoutParameters = lp;

            titleField.SetTextColor(Color.Black);
            titleField.SetTextSize(ComplexUnitType.Dip, 20);
            titleField.Typeface = Typeface.DefaultBold;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(23));
            titleField.LayoutParameters = titleLp;

            textField.SetTextColor(Color.DimGray);
            textField.SetTextSize(ComplexUnitType.Dip, 14);
            var textLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(18));
            textLp.SetMargins(0, DpToPx(10), 0, DpToPx(10));
            textLp.AddRule(LayoutRules.Below, titleField.Id);
            textField.LayoutParameters = textLp;

            var buttonLp = new LayoutParams(LayoutParams.MatchParent, DpToPx(55)); //TODO: Fix the right corner not rounding issue
            buttonLp.AddRule(LayoutRules.Below, textField.Id);
            buttonLp.SetMargins(0, DpToPx(10), 0, DpToPx(8));
            button.LayoutParameters = buttonLp;

            var imageLp = new LayoutParams(DpToPx(40), DpToPx(40));
            imageLp.AddRule(LayoutRules.AlignParentRight);
            image.LayoutParameters = imageLp;

            AddView(titleField);
            AddView(textField);
            AddView(button);
            AddView(image);
        }

        public void AddTitle(string title)
        {
            titleField.Text = title;
        }

        public void AddText(string text)
        {
            textField.Text = text;
        }
    }
}
