namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private void Button15Percent_Clicked(object sender, EventArgs e)
        {

        }
        private void Button30percent_Clicked(object sender, EventArgs e)
        {

        }
        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

        }
        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
        }

        private void PercentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PorcentagemLabel.Text = $"{PercentagemSlider.Value.ToString()}%";

        }
    }
}
