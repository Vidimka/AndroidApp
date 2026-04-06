using Android.Content;
using Android.Graphics;
using Android.Util;

namespace AndroidLib
{
    public class TransparentButton : Button
    {
        public TransparentButton(Context? context) : base(context)
        {
            Initialize();
        }

        void Initialize()
        {
            Text = "Button";
            SetTextColor(Color.ParseColor("#428BF9"));
            SetTextSize(ComplexUnitType.Dip, 14);
            SetBackgroundColor(Color.Transparent);
        }
    }
}
