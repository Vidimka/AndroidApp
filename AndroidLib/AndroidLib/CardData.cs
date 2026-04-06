using Android.Icu.Lang;

namespace AndroidLib
{
    public class CardData
    {
        string title { get; set; }
        string description { get; set; }
        int imageId { get; set; }

        public CardData(string title, string description, int imageId) 
        {
            this.title = title;
            this.description = description;
            this.imageId = imageId;
        }
    }
}
