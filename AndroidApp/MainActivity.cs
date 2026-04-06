using Android.Views;
using Android.Graphics;
using AndroidLib;

using static AndroidLib.Util;
using AndroidX.RecyclerView.Widget;

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();

            var recyclerView = new RecyclerView(this);

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
            buttonCard.AddTitle("Header");
            buttonCard.AddText("Subheader");
            buttonCard.SetPadding(DpToPx(20), DpToPx(10), DpToPx(20), DpToPx(10));

            var itemCard = new ItemCard(this, "Title", "Description", Resource.Drawable.atom);
            itemCard.AddCross(Resource.Drawable.cross);
            itemCard.SetPadding(DpToPx(20), DpToPx(10), DpToPx(20), DpToPx(10));

            var cardDataList = new List<CardData>();
            cardDataList.Add(new CardData("0", "0d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("1", "1d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("2", "2d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("3", "3d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("4", "4d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("5", "5d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("6", "6d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("7", "7d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("8", "8d", Resource.Drawable.atom));
            cardDataList.Add(new CardData("9", "9d", Resource.Drawable.atom));

            var listCard = new ListCard(this, Resource.Drawable.atom, cardDataList);
            listCard.AddTitle("Header");
            listCard.SetPadding(DpToPx(20), DpToPx(10), DpToPx(20), DpToPx(10));

            var button = new CustomButton(this);
            button.SetPadding(DpToPx(20), DpToPx(10), DpToPx(20), DpToPx(10));

            layout.AddView(subtextCard);
            layout.AddView(basicCard);
            layout.AddView(buttonCard);
            layout.AddView(itemCard);
            layout.AddView(listCard);
            layout.AddView(button);

            SetContentView(layout);
        }
    }
}