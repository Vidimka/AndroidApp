using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class ListCard : BasicCard
    {
        protected TransparentButton upperButton;
        public ListCard(Context? context, int imageId, List<CardData> cardDataList) : base(context, imageId)
        {
            Initialize(imageId, cardDataList);
        }

        protected void Initialize(int imageId, List<CardData> cardDataList)
        {
            RemoveView(image);
            titleField = new TextView(Context);
            titleField.Id = View.GenerateViewId();
            upperButton = new TransparentButton(Context);

            titleField.SetTextColor(Color.Black);
            titleField.SetTextSize(ComplexUnitType.Dip, 20);
            titleField.Typeface = Typeface.DefaultBold;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(23));
            titleLp.TopMargin = DpToPx(8);
            titleField.LayoutParameters = titleLp;

            var buttonLp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            buttonLp.AddRule(LayoutRules.AlignParentRight);
            upperButton.LayoutParameters = buttonLp;

            var recyclerView = new RecyclerView(Context);
            recyclerView.SetLayoutManager(new LinearLayoutManager(Context));
            var cardAdapter = new CardAdapter(cardDataList);
            recyclerView.SetAdapter(cardAdapter);

            var recyclerLp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            recyclerLp.AddRule(LayoutRules.Below, titleField.Id);
            recyclerView.LayoutParameters = recyclerLp;

            AddView(titleField);
            AddView(upperButton);
            AddView(recyclerView);
        }
    }
}
