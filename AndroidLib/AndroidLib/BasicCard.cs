using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;

using static AndroidLib.Util;

namespace AndroidLib
{
    public class BasicCard : RelativeLayout
    {
        protected TextView titleField;
        protected ImageView image;

        protected static int radiusValue = DpToPx(24);
        protected static float[] outerRadii = {radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue};
        protected static RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
        protected ShapeDrawable backgroundShape = new ShapeDrawable(roundRect);
        public BasicCard(Context? context, int imageId) : base(context)
        {
            Initialize(imageId);
        }

        protected void Initialize(int imageId)
        {
            titleField = new TextView(Context);
            image = new ImageView(Context);
            image.SetImageResource(imageId);

            Elevation = DpToPx(50);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            lp.BottomMargin = DpToPx(20);
            LayoutParameters = lp;
            
            titleField.SetTextColor(Color.Black);
            titleField.SetTextSize(ComplexUnitType.Dip, 20);
            titleField.Typeface = Typeface.DefaultBold;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(23));
            titleField.LayoutParameters = titleLp;

            var imageLp = new LayoutParams(DpToPx(40), DpToPx(40));
            imageLp.AddRule(LayoutRules.AlignParentRight);
            image.LayoutParameters = imageLp;

            AddView(titleField);
            AddView(image);
        }

        public void AddTitle(string title) => titleField.Text = title;
    }
}
