namespace AndroidLib
{
    public class CardData
    {
        public string title { get; private set; }
        public string description { get; private set; }
        public int imageId { get; private set; }

        public CardData(string title, string description, int imageId) 
        {
            this.title = title;
            this.description = description;
            this.imageId = imageId;
        }
    }
}
