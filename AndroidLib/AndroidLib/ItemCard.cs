using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Icu.Lang;
using Android.Util;
using Android.Views;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class ItemCard : RelativeLayout // Rethink the whole class its trash honestly
    {
        protected ShapeDrawable backgroundShape = GetRoundRect(24);
        string title {  get; set; }
        string description { get; set; }
        int atomId { get; set; }
        ImageButton cross;

        public ItemCard(Context? context) : base(context) => Initialize();
        public ItemCard(Context? context, string title, string description, int atomId) : base(context)
        {
            this.title = title;
            this.description = description;
            this.atomId = atomId;
            Initialize();
            RelativeLayout item = CreateItem(atomId, title, description);
            AddView(item);
        }

        void Initialize()
        {
            Elevation = DpToPx(10);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            lp.BottomMargin = DpToPx(20);
            LayoutParameters = lp;
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

        public void AddTitle(string title) => this.title = title;

        public void AddDescription(string description) => this.description = description;

        public void AddAtom(int atomId) => this.atomId = atomId;

        public void AddCross(int imageId) 
        {
            cross = new ImageButton(Context);
            cross.SetImageResource(imageId);
            cross.Click += (sender, e) => ((ViewGroup)Parent).RemoveView(this);

            var crossLp = new LayoutParams(DpToPx(24), DpToPx(24));
            crossLp.AddRule(LayoutRules.AlignParentRight);
            cross.LayoutParameters = crossLp;
            AddView(cross);
        }
    }
}
