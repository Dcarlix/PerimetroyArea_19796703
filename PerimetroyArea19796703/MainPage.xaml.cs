namespace PerimetroyArea19796703
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
		private void Button_Clicked(object sender, EventArgs e)
		{
            if (double.TryParse(Altura.Text, out double alt) && double.TryParse(Base.Text, out double basee) && double.TryParse(Lado2.Text, out double l2) && double.TryParse(Lado3.Text, out double l3))
            {
                double area = (alt * basee)/ 2;

                double perimetro = basee + l2 + l3;

                ResultArea.Text = area.ToString();
                ResultPerimetro.Text = perimetro.ToString();
            }
            else
            {
                DisplayAlert("Error", "Solo numeros y no dejar en vacio", "Ok");
            }
        }
    }

}
