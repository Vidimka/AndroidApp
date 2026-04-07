using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace AndroidLib
{
    public class CardAdapter : RecyclerView.Adapter
    {
        List<CardData> cardDataList = new List<CardData>();
        public override int ItemCount => cardDataList.Count;

        public CardAdapter(List<CardData> cardDataList) => this.cardDataList = cardDataList;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var card = new ItemCard(parent.Context);
            return new CardViewHolder(card);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var cardHolder = (CardViewHolder) holder;
            cardHolder.itemCard.AddAtom(cardDataList[position].imageId);
            cardHolder.itemCard.AddTitle(cardDataList[position].title);
            cardHolder.itemCard.AddDescription(cardDataList[position].description);
        }
    }

    public class CardViewHolder : RecyclerView.ViewHolder
    {
        public ItemCard itemCard;
        public CardViewHolder(View itemView) : base(itemView) => itemCard = (ItemCard)itemView;
    }
}