class Restaurante
{
    public string? Nome { get; set; }
    public string? Endereco { get; set; }
    public List<Mesa>? MesasReservadas { get; set; } = new List<Mesa>();
    public Cardapio? Cardapio { get; set; } = new Cardapio();
}