using Android.Content;
using Android.Graphics;
using Android.Util;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class ListCard : BasicCard // TODO: Fix the darker color
    {
        protected TransparentButton upperButton;
        public ListCard(Context? context, int imageId) : base(context, imageId)
        {
            Initialize();
        }

        void Initialize()
        {
            titleField = new TextView(Context);
            image = null;
            upperButton = new TransparentButton(Context);

            Elevation = DpToPx(10);
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

            AddView(titleField);
        }
    }
}
