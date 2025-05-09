class Usuario : IAutenticavel
{
    public string? Nome { get; set; }
    public string? SenhaCorreta;


    public void Autenticar(string senha)
    {
        if (senha == SenhaCorreta)
        {
            Console.WriteLine("Acesso concedido");
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }
    }
}