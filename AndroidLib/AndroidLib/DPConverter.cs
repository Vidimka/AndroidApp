using Android.Util;

namespace AndroidLib
{
    public class DPConverter
    {
        public static float DPToPixels(int dp)
        {
            return dp * Application.Context.Resources.DisplayMetrics.Density;
        }

        public static float PixelsToDP(int pixels) 
        {
            return pixels / Application.Context.Resources.DisplayMetrics.Density;
        }
    }
}
