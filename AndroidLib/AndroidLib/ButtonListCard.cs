using Android.Content;

namespace AndroidLib
{
    public class ButtonListCard : ListCard
    {
        public ButtonListCard(Context? context, int imageId, List<CardData> cardDataList) : base(context, imageId, cardDataList)
        {
            base.Initialize(imageId, cardDataList);
            Initialize();
        }

        void Initialize() 
        {
            var button = new CustomButton(Context);
            var buttonLp = new LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
            buttonLp.AddRule(LayoutRules.AlignParentBottom);
            button.LayoutParameters = buttonLp;

            AddView(button);
        }
    }
}
