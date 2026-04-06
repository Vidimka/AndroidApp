/*using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace AndroidLib
{
    public class CardAdapter : RecyclerView.Adapter
    {
        List<CardData> cardDataList = new List<CardData>();
        public override int ItemCount => cardDataList.Count;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = new ItemCard(parent.Context, atomId);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

        }

        public class CardViewHolder : RecyclerView.ViewHolder
        {
            LinearLayout layout;
            public CardViewHolder(View itemView) : base(itemView)
            {
                layout = itemView;
            }
        }
    }
}
*/