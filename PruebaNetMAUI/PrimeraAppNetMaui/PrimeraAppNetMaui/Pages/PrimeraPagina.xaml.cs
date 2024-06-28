namespace PrimeraAppNetMaui.Pages;

public partial class PrimeraPagina : ContentPage
{
	public PrimeraPagina()
	{
		InitializeComponent();
        btnInstituto.Clicked += BtnInstituto_Clicked;
        btnCarrera.Clicked += async (s, a) => {

            await Application.Current.MainPage.DisplayAlert("Carrera", "Técnico Superior en Desarrollo de software", "Ok");

        };
	}

    private async void BtnInstituto_Clicked(object? sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Institución", "Instituto de Profesorado N°20 \"Sdor Nestor Zamaro\"", "Ok");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Application.Current.MainPage.DisplayAlert("Ventana de mensaje", "Hola mundo y bienvenido a .NET MAUI", "Ok");

    }
}