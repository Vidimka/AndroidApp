using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Views;

namespace AndroidLib
{
    public class BasicCard : RelativeLayout
    {
        float width = DPConverter.DPToPixels(328);
        float height = DPConverter.DPToPixels(144);

        TextView titleField;
        TextView textField;
        Button button;
        ImageView image;

        static float[] outerRadii = {50, 50, 50, 50, 50, 50, 50, 50};
        static RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
        ShapeDrawable backgroundShape = new ShapeDrawable(roundRect);
        public BasicCard(Context? context) : base(context)
        {
            Initialize();
        }

        void Initialize()
        {
            titleField = new TextView(this.Context);
            titleField.Id = View.GenerateViewId();
            textField = new TextView(this.Context);
            textField.Id = View.GenerateViewId();
            button = new Button(this.Context);
            image = new ImageView(this.Context); //TODO: Add a star image to this

            backgroundShape.SetTint(Color.White);
            this.Background = backgroundShape;
            var lp = new LayoutParams((int)width, (int)height);
            this.LayoutParameters = lp;
            
            titleField.SetTextColor(Color.Black);
            titleField.SetTextSize(Android.Util.ComplexUnitType.Dip, 20);
            titleField.Typeface = Typeface.DefaultBold;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, (int)DPConverter.DPToPixels(23));
            textField.LayoutParameters = titleLp;

            textField.SetTextColor(Color.DimGray);
            titleField.SetTextSize(Android.Util.ComplexUnitType.Dip, 14);
            var textLp = new LayoutParams(LayoutParams.WrapContent, (int) DPConverter.DPToPixels(18));
            textLp.SetMargins(0, 10, 0, 10);
            textLp.AddRule(LayoutRules.Below, titleField.Id);
            textField.LayoutParameters = textLp;

            button.Text = "Button";
            var buttonLp = new LayoutParams(LayoutParams.MatchParent, (int)DPConverter.DPToPixels(55));
            buttonLp.AddRule(LayoutRules.Below, textField.Id);
            buttonLp.SetMargins(20, 16, 20, 0);
            button.LayoutParameters = buttonLp;

            AddView(titleField);
            AddView(textField);
            AddButton();
        }

        public void AddTitle(string title) 
        {
            titleField.Text = title;
        }

        public void AddText(string text)
        {
            textField.Text = text;
        }

        public void AddButton()
        {
            AddView(button);
        }
    }
}
