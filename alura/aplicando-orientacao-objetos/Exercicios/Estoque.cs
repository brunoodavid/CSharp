class Estoque
{
    private List<Produto>? _produtos;

    public Estoque()
    {
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
        Console.WriteLine($"Produto {produto} adicionado com sucesso!\n");
    }
    public void ExibirProdutos()
    {
        if (_produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio");
        }
        else
        {
            foreach (var produto in _produtos)
            {
                Console.WriteLine(produto.DescricaoDetalhada);
            }
        }
    }
}