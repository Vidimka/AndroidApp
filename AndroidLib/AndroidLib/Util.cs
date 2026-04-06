using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;

namespace AndroidLib
{
    public class Util
    {
        public static int DpToPx(int dp) => (int)(dp * Application.Context.Resources.DisplayMetrics.Density);

        public static int PxToDp(int pixels) => (int)(pixels / Application.Context.Resources.DisplayMetrics.Density);

        public static ShapeDrawable GetRoundRect(int dpValue) {
            int radiusValue = DpToPx(dpValue);
            float[] outerRadii = { radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue };
            RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
            return new ShapeDrawable(roundRect);
        }
    }
}
