using Android.Content;

namespace AndroidLib
{
    public class ButtonListCard : ListCard
    {
        public ButtonListCard(Context? context, int imageId, ItemCard itemCard) : base(context, imageId, itemCard)
        {
            base.Initialize(imageId);
            Initialize();
        }

        void Initialize() 
        {
            RemoveView(image);
            var button = new CustomButton(Context);
            var buttonLp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            buttonLp.AddRule(LayoutRules.AlignParentBottom);
            button.LayoutParameters = buttonLp;

            AddView(button);
        }
    }
}
