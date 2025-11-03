using System;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto? QuartoSelecionado { get; set; } = null;
        public int QntAdultos { get; set; } = 0;
        public int QntCriancas { get; set; } = 0;
        public DateTime DataCheckIn { get; set; } = DateTime.Today;
        public DateTime DataCheckOut { get; set; } = DateTime.Today.AddDays(1);

        public int Estadia => DataCheckOut.Subtract(DataCheckIn).Days;

        public double ValorTotal
        {
            get
            {
                if (QuartoSelecionado == null) return 0.0;

                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                return (valor_adultos + valor_criancas) * Estadia;
            }
        }

        public Hospedagem() { }

        public Hospedagem(Quarto quarto, int adultos, int criancas, DateTime checkIn, DateTime checkOut)
        {
            QuartoSelecionado = quarto;
            QntAdultos = adultos;
            QntCriancas = criancas;
            DataCheckIn = checkIn;
            DataCheckOut = checkOut;
        }
    }
}
