using CadastraApp.Models;

namespace CadastraApp;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)   
    {
        InitializeComponent();
        BindingContext = evento;
    }
}