using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Preencher Picker com os quartos do App
            if (Application.Current is App app)
            {
                PickerQuartos.ItemsSource = app.lista_quartos;
                PickerQuartos.ItemDisplayBinding = new Binding("Descricao");
            }
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if (Application.Current is not App app) return;

            // Validar entradas
            if (!int.TryParse(EntryAdultos.Text, out int adultos)) adultos = 0;
            if (!int.TryParse(EntryCriancas.Text, out int criancas)) criancas = 0;

            if (PickerQuartos.SelectedItem is not Quarto quartoSelecionado)
            {
                DisplayAlert("Erro", "Selecione um tipo de suíte.", "OK");
                return;
            }

            // Criar hospedagem
            var hospedagem = new Hospedagem
            {
                QuartoSelecionado = quartoSelecionado,
                QntAdultos = adultos,
                QntCriancas = criancas,
                DataCheckIn = DateCheckIn.Date,
                DataCheckOut = DateCheckOut.Date
            };

            // Mostrar resultado
            LabelResultado.Text = $"O valor total da hospedagem é: R$ {hospedagem.ValorTotal:F2}";
        }
    }
}
