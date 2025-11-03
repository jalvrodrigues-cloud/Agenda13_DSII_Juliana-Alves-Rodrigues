using Microsoft.Maui.Controls;
using MauiAppHotel.Models;
using System.Collections.Generic;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // Lista de quartos inicializada
        public List<Quarto> lista_quartos { get; set; } = new List<Quarto>();

        // Quarto selecionado — anulável
        public Quarto? QuartoSelecionado { get; set; } = null;

        // Lista de hospedagens inicializada
        public List<Hospedagem> lista_hospedagens { get; set; } = new List<Hospedagem>();

        // PropriedadesApp inicializada
        public List<string> PropriedadesApp { get; set; } = new List<string>();

        public App()
        {
            InitializeComponent();

            // Exemplo: adicionar quartos iniciais
            lista_quartos.Add(new Quarto("Quarto Luxo", 200, 100));
            lista_quartos.Add(new Quarto("Quarto Standard", 150, 75));

            MainPage = new AppShell();
        }
    }
}
