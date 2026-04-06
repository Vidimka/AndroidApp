using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class ListCard : BasicCard // TODO: Fix the darker color
    {
        protected TransparentButton upperButton;
        public ListCard(Context? context, int imageId, ItemCard item) : base(context, imageId)
        {
            Initialize(imageId, item);
        }

        void Initialize(int imageId, ItemCard itemCard)
        {
            RemoveView(image);
            titleField = new TextView(Context);
            titleField.Id = View.GenerateViewId();
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
            titleLp.TopMargin = DpToPx(8);
            titleField.LayoutParameters = titleLp;

            var buttonLp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            buttonLp.AddRule(LayoutRules.AlignParentRight);
            upperButton.LayoutParameters = buttonLp;

            AddView(titleField);
            AddView(upperButton);

            int prevItemId = titleField.Id;
            for (int i=0; i<4; i++) 
            {
                var item = itemCard.CreateItem(imageId, "Title", "Description");
                var itemLp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                itemLp.TopMargin = DpToPx(12);
                itemLp.AddRule(LayoutRules.Below, prevItemId);
                item.LayoutParameters = itemLp;
                AddView(item);
                item.Id = View.GenerateViewId();
                prevItemId = item.Id;
            }
        }
    }
}
