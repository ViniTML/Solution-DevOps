namespace WebApi.Models
{
    public class Produto : Base
    {
        public string? Nome { get; set; }
        public string? Drescricao { get; set; }
        public string? Categoria { get; set; }
        public decimal Preco { get; set; }

    }
}
