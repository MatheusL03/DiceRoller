namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            ListView listView = new ListView();
            listView.SetBinding(ItemsView.ItemsSourceProperty, "Number");

        }
    }

}
