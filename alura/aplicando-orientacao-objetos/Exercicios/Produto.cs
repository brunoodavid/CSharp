class Produto
{
    private double _preco;
    public string? Nome { get; set; }
    public string? Marca { get; set; }
    public double Preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if (value > 0)
            {
                _preco = value;
            }
            else
            {
                _preco = 0;
            }
        }
    }
    public string? DescricaoDetalhada { get => $"O produto {this.Nome} da marca {this.Marca} tem um valor de R${this.Preco}"; }
}