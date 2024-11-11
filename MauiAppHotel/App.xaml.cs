
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 115.0,
                ValorDiariaCrianca = 55.0

            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 85.0,
                ValorDiariaCrianca = 45.0
            },
            new Quarto()
            {
                Descricao = "Suíte Primer",
                ValorDiariaAdulto = 65.0,
                ValorDiariaCrianca = 30.0
            },
            new Quarto()
            {
                Descricao = "Suíte Economic",
                ValorDiariaAdulto = 48.5,
                ValorDiariaCrianca = 20.0
            },
            new Quarto()
            {
                Descricao = "Suíte Incluso PlayGound",
                ValorDiariaAdulto = 95.0,
                ValorDiariaCrianca = 55.0,
                ValorPlaygound = 30.0

            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
