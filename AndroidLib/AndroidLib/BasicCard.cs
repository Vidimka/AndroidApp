using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;

namespace AndroidLib
{
    public class BasicCard : RelativeLayout
    {
        TextView titleField;
        TextView textField;
        Button button;
        ImageView image;

        static float[] outerRadii = {50, 50, 50, 50, 50, 50, 50, 50};
        static RoundRectShape roundRect1 = new RoundRectShape(outerRadii, null, null);
        static RoundRectShape roundRect2 = new RoundRectShape(outerRadii, null, null);
        ShapeDrawable backgroundShape = new ShapeDrawable(roundRect1);
        ShapeDrawable buttonBackground = new ShapeDrawable(roundRect2);
        public BasicCard(Context? context, int imageId) : base(context)
        {
            Initialize(imageId);
        }

        void Initialize(int imageId)
        {
            titleField = new TextView(this.Context);
            titleField.Id = View.GenerateViewId();
            textField = new TextView(this.Context);
            textField.Id = View.GenerateViewId();
            button = new Button(this.Context);
            image = new ImageView(this.Context);
            image.SetImageResource(imageId);

            Elevation = DPConverter.DPToPixels(50);
            backgroundShape.SetTint(Color.White);
            Background = backgroundShape;
            var lp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            LayoutParameters = lp;
            
            titleField.SetTextColor(Color.Black);
            titleField.SetTextSize(ComplexUnitType.Dip, 20);
            titleField.Typeface = Typeface.DefaultBold;
            var titleLp = new LayoutParams(LayoutParams.WrapContent, (int)DPConverter.DPToPixels(23));
            textField.LayoutParameters = titleLp;

            textField.SetTextColor(Color.DimGray);
            textField.SetTextSize(ComplexUnitType.Dip, 14);
            var textLp = new LayoutParams(LayoutParams.WrapContent, (int) DPConverter.DPToPixels(18));
            textLp.SetMargins(0, 10, 0, 10);
            textLp.AddRule(LayoutRules.Below, titleField.Id);
            textField.LayoutParameters = textLp;

            buttonBackground.SetTint(Color.ParseColor("#F6F7F8"));
            button.Text = "Button";
            button.SetTextColor(Color.ParseColor("#428BF9"));
            button.SetTextSize(ComplexUnitType.Dip, 14);
            button.Background = buttonBackground;
            var buttonLp = new LayoutParams(LayoutParams.MatchParent, (int)DPConverter.DPToPixels(55));
            buttonLp.AddRule(LayoutRules.Below, textField.Id);
            buttonLp.SetMargins(20, 16, 20, 0);
            button.LayoutParameters = buttonLp;

            var imageLp = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            imageLp.AddRule(LayoutRules.AlignParentRight);
            image.LayoutParameters = imageLp;

            AddView(titleField);
            AddView(textField);
            AddView(button);
            AddView(image);
        }

        public void AddTitle(string title) 
        {
            titleField.Text = title;
        }

        public void AddText(string text)
        {
            textField.Text = text;
        }
    }
}
