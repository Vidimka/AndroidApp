using Android.Content;
using Android.Graphics;

namespace AndroidLib
{
    public class BasicCard : FrameLayout
    {
        public virtual string Title {  get; set; }
        private TextView titleField;
        private TextView textField;
        private Color background = Color.Rgb(0xF6, 0xF7, 0xF8);
        public BasicCard(Context? context) : base(context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SetBackgroundColor(background);

            titleField = new TextView(this.Context);
            textField = new TextView(this.Context);
            textField.SetPadding(0, 50, 0, 0);
            AddView(titleField);
            AddView(textField);
        }

        public void AddText(string text)
        {
            textField.Text = text;
        }

        public void AddTitle(string title) 
        {
            titleField.Text = title;
        }
    }
}
