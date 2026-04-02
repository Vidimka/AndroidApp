using Android.Views;
using Android.Graphics;
using AndroidLib;

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
            layout.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.MatchParent);
            layout.SetPadding(30, 30, 30, 30);
            layout.SetBackgroundColor(Color.DimGray);

            var basicCard = new BasicCard(this);
            basicCard.AddText("A Basic Form");
            basicCard.AddTitle("A Basic Title");
            basicCard.SetPadding((int) DPConverter.DPToPixels(16), (int)DPConverter.DPToPixels(16), (int) DPConverter.DPToPixels(16), (int) DPConverter.DPToPixels(16));

            layout.AddView(basicCard);
            SetContentView(layout);
            
        }
    }
}