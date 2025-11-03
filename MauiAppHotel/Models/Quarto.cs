namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public string Descricao { get; set; } = string.Empty;
        public double ValorDiariaAdulto { get; set; } = 0.0;
        public double ValorDiariaCrianca { get; set; } = 0.0;

        public Quarto() { }

        public Quarto(string descricao, double valorAdulto, double valorCrianca)
        {
            Descricao = descricao;
            ValorDiariaAdulto = valorAdulto;
            ValorDiariaCrianca = valorCrianca;
        }
    }
}
