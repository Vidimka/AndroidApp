namespace AndroidLib
{
    public class Util
    {
        public static int DpToPx(int dp)
        {
            return (int)(dp * Application.Context.Resources.DisplayMetrics.Density);
        }

        public static int PxToDp(int pixels) 
        {
            return (int)(pixels / Application.Context.Resources.DisplayMetrics.Density);
        }
    }
}
