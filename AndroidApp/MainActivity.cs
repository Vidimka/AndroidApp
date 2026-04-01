

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            TextView textView = new TextView(this);
            textView.Text = "Hello World!";
            LinearLayout layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            layout.AddView(textView);

            base.OnCreate(savedInstanceState);
            SetContentView(layout);

        }
    }
}