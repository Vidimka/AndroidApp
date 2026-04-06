using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class ItemCard : RelativeLayout
    {
        static int radiusValue = DpToPx(24);
        static float[] outerRadii = { radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue };
        static RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
        static ShapeDrawable backgroundShape = new ShapeDrawable(roundRect);

        ImageButton cross;
        public ItemCard(Context? context, int atomId) : base(context)
        {
            Initialize(atomId);
        }

        void Initialize(int atomId)
        {
            Elevation = DpToPx(50);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            lp.BottomMargin = DpToPx(20);
            LayoutParameters = lp;
            int amount = 2;
            RelativeLayout item = CreateItem(atomId, "Title", "Description");
            AddView(item);
        }

        public RelativeLayout CreateItem(int atomId, string title, string description)
        {   
            RelativeLayout item = new RelativeLayout(Context);
            item.Id = View.GenerateViewId();

            ImageView atom = new ImageView(Context);
            atom.Id = View.GenerateViewId();
            atom.SetImageResource(atomId);
            TextView itemTitle = new TextView(Context);
            itemTitle.Id = View.GenerateViewId();
            TextView textField = new TextView(Context);

            var atomLp = new LayoutParams(DpToPx(40), DpToPx(40));
            atomLp.AddRule(LayoutRules.AlignParentLeft);
            atomLp.SetMargins(0, DpToPx(12), DpToPx(16), 0);
            atom.LayoutParameters = atomLp;

            itemTitle.Text = title;
            itemTitle.SetTextColor(Color.Black);
            itemTitle.SetTextSize(ComplexUnitType.Dip, 16);
            itemTitle.Typeface = Typeface.Default;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(19));
            titleLp.SetMargins(0, DpToPx(12), 0, 0);
            titleLp.AddRule(LayoutRules.RightOf, atom.Id);
            itemTitle.LayoutParameters = titleLp;

            textField.Text = description;
            textField.SetTextSize(ComplexUnitType.Dip, 13);
            var textLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(15));
            textLp.SetMargins(DpToPx(56), DpToPx(4), 0, DpToPx(10));
            textLp.AddRule(LayoutRules.Below, itemTitle.Id);
            textField.LayoutParameters = textLp;

            item.AddView(atom);
            item.AddView(itemTitle);
            item.AddView(textField);
            return item;
        }

        public void AddCross(int imageId) 
        {
            cross = new ImageButton(Context);
            cross.SetImageResource(imageId);
            cross.Click += (sender, e) =>
            {
                ((ViewGroup)Parent).RemoveView(this);
            };

            var crossLp = new LayoutParams(DpToPx(24), DpToPx(24));
            crossLp.AddRule(LayoutRules.AlignParentRight);
            cross.LayoutParameters = crossLp;
            AddView(cross);
        }
    }
}
