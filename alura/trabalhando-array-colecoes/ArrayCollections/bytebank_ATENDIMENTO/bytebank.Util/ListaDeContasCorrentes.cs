using bytebank.Modelos.Conta;

public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao = 0;

    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void AdicionarConta(ContaCorrente item)
    {
        Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
        VerificarCapacidade(_proximaPosicao + 1);
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length >= tamanhoNecessario)
        {
            return;
        }

        Console.WriteLine("Aumentando a capacidade da lista!");
        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

        for (int i = 0; i < _itens.Length; i++)
        {
            novoArray[i] = _itens[i];
        }

        _itens = novoArray;
    }

    public void MaiorSaldoDeContasCorrentes()
    {
        if (_proximaPosicao == 0)
        {
            Console.WriteLine("Nenhuma conta adicionada.");
            return;
        }

        double maiorSaldo = 0;
        string nomeTitular = "Titular desconhecido";

        for (int i = 0; i < _proximaPosicao; i++)
        {
            ContaCorrente item = _itens[i];
            string nome = item.Titular.Nome;

            if (item != null && item.Saldo > maiorSaldo)
            {
                maiorSaldo = item.Saldo;
                nomeTitular = nome;
            }
        }

        Console.WriteLine($"O maior saldo é de {maiorSaldo:C} e pertence a {nomeTitular}.");
    }

    public void Remover(ContaCorrente conta)
    {

        int indiceItem = -1;

        for (int i = 0; i < _proximaPosicao; i++)
        {

            ContaCorrente contaAtual = _itens[i];
            if (contaAtual == conta)
            {
                indiceItem = i;
                break;
            }
        }

        for (int i = indiceItem; i < _proximaPosicao - 1; i++)
        {
            _itens[i] = _itens[i + 1];
        }
        _proximaPosicao--;
        _itens[_proximaPosicao] = null;
    }

    public void ExibeLista()
    {
        for (int i = 0; i < _proximaPosicao; i++)
        {
            Console.Write($"Índice [{i}] =  ");
            Console.Write($"Conta: {_itens[i].Conta} - ");
            Console.Write($"Número da Agencia: {_itens[i].Numero_agencia} ");
            Console.WriteLine();
        }
    }

    public ContaCorrente RecuperarContaNoIndice(int indice)
    {
        if (indice < 0 || indice >= _proximaPosicao)
        {
            throw new ArgumentOutOfRangeException(nameof(indice));
        }

        return _itens[indice];
    }

    public int Tamanho
    {
        get
        {
            return _proximaPosicao;
        }
    }

    public ContaCorrente this[int indice]
    {
        get
        {
            return RecuperarContaNoIndice(indice);
        }
    }
}
