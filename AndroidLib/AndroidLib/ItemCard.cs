using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;

using static AndroidLib.Util;

namespace AndroidLib
{
    public class ItemCard : RelativeLayout
    {
        protected ShapeDrawable backgroundShape = GetRoundRect(24);
        RelativeLayout item;
        TextView itemTitle;
        TextView textField;
        ImageView atom;

        ImageButton cross;

        #region ctor
        public ItemCard(Context? context) : base(context) => Initialize();
        public ItemCard(Context? context, IAttributeSet? attrs) : base(context, attrs) => Initialize();
        public ItemCard(Context? context, IAttributeSet? attrs, int defStyleAttr) : base(context, attrs, defStyleAttr) => Initialize();
        public ItemCard(Context? context, IAttributeSet? attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes) => Initialize();
        public ItemCard(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) => Initialize();
        public ItemCard(Context? context, string title, string description, int atomId) : base(context)
        {
            Initialize();
            AddAtom(atomId);
            AddTitle(title);
            AddDescription(description);
        }

        #endregion

        void Initialize()
        {
            Elevation = DpToPx(10);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            lp.BottomMargin = DpToPx(20);
            LayoutParameters = lp;

            atom = new ImageView(Context);
            atom.Id = View.GenerateViewId();
            itemTitle = new TextView(Context);
            itemTitle.Id = View.GenerateViewId();
            textField = new TextView(Context);

            item = new RelativeLayout(Context);
            AddView(item);
        }

        public void AddAtom(int atomId)
        {
            atom.SetImageResource(atomId);
            var atomLp = new LayoutParams(DpToPx(40), DpToPx(40));
            atomLp.AddRule(LayoutRules.AlignParentLeft);
            atomLp.SetMargins(0, DpToPx(12), DpToPx(16), 0);
            atom.LayoutParameters = atomLp;

            item.AddView(atom);
        }

        public void AddTitle(string title)
        {
            itemTitle.Text = title;
            itemTitle.SetTextColor(Color.Black);
            itemTitle.SetTextSize(ComplexUnitType.Dip, 16);
            itemTitle.Typeface = Typeface.Default;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(19));
            titleLp.SetMargins(0, DpToPx(12), 0, 0);
            titleLp.AddRule(LayoutRules.RightOf, atom.Id);
            itemTitle.LayoutParameters = titleLp;

            item.AddView(itemTitle);
        }

        public void AddDescription(string description)
        {
            textField.Text = description;
            textField.SetTextSize(ComplexUnitType.Dip, 13);
            var textLp = new LayoutParams(LayoutParams.WrapContent, DpToPx(15));
            textLp.SetMargins(DpToPx(56), DpToPx(4), 0, DpToPx(10));
            textLp.AddRule(LayoutRules.Below, itemTitle.Id);
            textField.LayoutParameters = textLp;

            item.AddView(textField);
        }

        public void AddCross(int imageId) 
        {
            cross = new ImageButton(Context);
            cross.SetImageResource(imageId);
            cross.Click += (sender, e) => ((ViewGroup)Parent).RemoveView(this);
            var crossLp = new LayoutParams(DpToPx(24), DpToPx(24));
            crossLp.AddRule(LayoutRules.AlignParentRight);
            cross.LayoutParameters = crossLp;

            item.AddView(cross);
        }
    }
}
