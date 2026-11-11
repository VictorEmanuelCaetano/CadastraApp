using CadastraApp.Models;

namespace CadastraApp
{
    public partial class MainPage : ContentPage
    {
        private Evento _evento = new Evento();

        public MainPage()
        {
            InitializeComponent();
            var outro = new Evento();
            BindingContext = _evento;

        }

        private async void OnCadastrarClicado(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResumoPage(_evento));
        }

    }
}
