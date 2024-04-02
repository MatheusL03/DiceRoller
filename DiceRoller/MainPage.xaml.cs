namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Sidespicker.SelectedIndex= 0;
        }

        int valor = 0;
        
        private void RollBtn_Clicked(object sender, EventArgs e)
        {

            valor = Convert.ToInt32(Sidespicker.SelectedItem);

            int valorSorteado = new Random().Next(1, (valor +1));

            ResulLabel.Text = valorSorteado.ToString();

        }
    }
}


