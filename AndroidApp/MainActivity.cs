using Android.Views;
using Android.Graphics;
using AndroidLib;

using static AndroidLib.Util;

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();

            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            layout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            layout.SetPadding(DpToPx(10), DpToPx(50), DpToPx(10), DpToPx(10));
            layout.SetBackgroundColor(Color.White);
            layout.SetClipToPadding(false);

            var subtextCard = new SubtextCard(this, Resource.Drawable.atom);
            subtextCard.AddTitle("Header");
            subtextCard.AddText("Subheader");
            subtextCard.SetPadding(DpToPx(20), DpToPx(16), DpToPx(20), DpToPx(20));

            var basicCard = new BasicCard(this, Resource.Drawable.atom);
            basicCard.AddTitle("Header");
            basicCard.SetPadding(DpToPx(20), DpToPx(16), DpToPx(20), DpToPx(20));

            var buttonCard = new ButtonCard(this, Resource.Drawable.atom);
            buttonCard.AddTitle("A Basic Title");
            buttonCard.AddText("A Basic Text");
            buttonCard.SetPadding(DpToPx(20), DpToPx(10), DpToPx(20), DpToPx(10));

            var button = new CustomButton(this);

            layout.AddView(subtextCard);
            layout.AddView(basicCard);
            layout.AddView(buttonCard);
            layout.AddView(button);
            SetContentView(layout);
        }
    }
}