using Android.Animation;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Util;
using Android.Views;
using static AndroidLib.Util;

namespace AndroidLib
{
    public class CustomButton : Button
    {
        public CustomButton(Context? context) : base(context)
        {
            Initialize();
        }

        void Initialize()
        {
            int radiusValue = DpToPx(12);
            float[] outerRadii = { radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue, radiusValue };
            RoundRectShape roundRect = new RoundRectShape(outerRadii, null, null);
            ShapeDrawable background = new ShapeDrawable(roundRect);
            background.SetTint(Color.ParseColor("#F6F7F8"));
            Text = "Button";
            SetTextColor(Color.ParseColor("#428BF9"));
            SetTextSize(ComplexUnitType.Dip, 14);
            Background = background;
            StateListAnimator = null;
            Touch += (sender, e) => {
                if (e.Event.Action == MotionEventActions.Down)
                {
                    background.SetTint(Color.LightGray);
                    Background = background;
                }
                else if (e.Event.Action == MotionEventActions.Up)
                {
                    background.SetTint(Color.ParseColor("#F6F7F8"));
                    Background = background;
                }
            };
        }

        /* Not used for now
        StateListAnimator SetScaleAnimation()
        {
            var stateListAnimator = new StateListAnimator();
            var scaleUpX = ObjectAnimator.OfFloat(this, "scaleX", 1.0f, 1.05f);
            var scaleUpY = ObjectAnimator.OfFloat(this, "scaleY", 1.0f, 1.05f);
            var pressedSet = new AnimatorSet();
            pressedSet.PlayTogether(scaleUpX, scaleUpY);
            var scaleDownX = ObjectAnimator.OfFloat(this, "scaleX", 1.05f, 1.0f);
            var scaleDownY = ObjectAnimator.OfFloat(this, "scaleY", 1.05f, 1.0f);
            var normalSet = new AnimatorSet();
            normalSet.PlayTogether(scaleDownX, scaleDownY);
            stateListAnimator.AddState(new[] { Android.Resource.Attribute.StatePressed }, pressedSet);
            stateListAnimator.AddState(new int[] { }, normalSet);
            return stateListAnimator;
        }
        */
    }
}
