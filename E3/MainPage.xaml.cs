namespace E3;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int nume1 = Convert.ToInt32(num1.Text);
        int nume2 = Convert.ToInt32(num2.Text);
        int nume3 = Convert.ToInt32(num3.Text);
        int nume4 = Convert.ToInt32(num4.Text);
        int nume5 = Convert.ToInt32(num5.Text);

        int r = (nume1 + nume2 + nume3 + nume4 + nume5) / 5;

        La.Text = "La calificacion es :" + r;
    }
}

