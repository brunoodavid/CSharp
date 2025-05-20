using bytebank.Modelos.Conta;

class byteBankAtendimentos
{
    private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>();
    // Contas criadas automaticamente

    public void AtendimentoCliente()
    {
        try
        {
            string opcao = "";
            while (opcao != "6")
            {
                Console.Clear();

                Console.WriteLine("===============================");
                Console.WriteLine("===       Atendimento       ===");
                Console.WriteLine("===1 - Cadastrar Conta      ===");
                Console.WriteLine("===2 - Listar Contas        ===");
                Console.WriteLine("===3 - Remover Conta        ===");
                Console.WriteLine("===4 - Ordenar Contas       ===");
                Console.WriteLine("===5 - Pesquisar Conta      ===");
                Console.WriteLine("===6 - Sair do Sistema      ===");
                Console.WriteLine("===============================");
                Console.WriteLine("\n\n");

                Console.Write("Digite a opção desejada: ");
                try
                {
                    opcao = Console.ReadLine()!;
                }
                catch (Exception excecao)
                {

                    throw new ByteBankExceptions(excecao.Message);
                }


                switch (opcao)
                {
                    case "1":
                        CadastrarConta();
                        break;
                    case "2":
                        ListarContas();
                        break;
                    case "3":
                        RemoverContas();
                        break;
                    case "4":
                        OrderanarContas();
                        break;
                    case "5":
                        PesquisarContas();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        catch (ByteBankExceptions execao)
        {
            Console.WriteLine(execao.Message);
        }

    }


    private void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("=== Informe dados da conta ===");

        Console.WriteLine("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine()!);

        ContaCorrente conta = new ContaCorrente(numeroAgencia);

        Console.WriteLine($"Número da conta [NOVA] {conta.Conta}");

        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine()!);

        Console.Write("Informe o nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine()!;

        Console.Write("Informe o CPF do titular: ");
        conta.Titular.Cpf = Console.ReadLine()!;

        Console.Write("Informe a profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine()!;

        _listaDeContas.Add(conta);
        Console.WriteLine("Conta cadastrada com sucesso!");
        Console.ReadKey();
    }

    private void ListarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     LISTA DE CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");

        if (_listaDeContas.Count < 0)
        {
            Console.WriteLine("Não há contas cadastradas!");
            Console.ReadKey();
            return;
        }

        foreach (ContaCorrente item in _listaDeContas)
        {
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
    }

    private void RemoverContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===      REMOVER CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("Informe o número da conta: ");
        string numeroConta = Console.ReadLine()!;

        var conta = _listaDeContas.FirstOrDefault(c => c.Conta == numeroConta);

        if (conta != null)
        {
            _listaDeContas.Remove(conta);
            Console.WriteLine("Conta removida da lista!");
        }
        else
        {
            Console.WriteLine("Conta para remoção não encontrada!");
        }
        Console.ReadKey();
    }

    private void OrderanarContas()
    {
        _listaDeContas.Sort();
        Console.WriteLine("Lista de contas ordenadas");
        Console.ReadKey();

    }

    private void PesquisarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===    PESQUISAR CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2) CPF TITULAR ou (3) Nº AGÊNCIA: ");
        switch (int.Parse(Console.ReadLine()!))
        {
            case 1:
                {
                    Console.Write("Informe o número da conta: ");
                    string numeroConta = Console.ReadLine()!;
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(numeroConta);
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.Write("Informe o CPF do titular: ");
                    string cpf = Console.ReadLine()!;
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(cpf);
                    Console.WriteLine(consultaCpf.ToString());
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.Write("Informe o Nº da Agência: ");
                    int _numeroAgencia = int.Parse(Console.ReadLine()!);
                    var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                    ExibirListaDeContas(contasPorAgencia);
                    Console.ReadKey();
                    break;
                }
            default:
                Console.WriteLine("Opção nao implementada");
                break;
        }
    }


    private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
    {
        return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault()!;
    }

    private ContaCorrente ConsultaPorCPFTitular(string? cpf)
    {

        return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault()!;
    }

    private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
    {
        var consulta = (
            from conta in _listaDeContas
            where conta.Numero_agencia == numeroAgencia
            select conta).ToList();
        return consulta;
    }

    private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
    {
        if (contasPorAgencia == null)
        {
            Console.WriteLine("A consulta não retornou dados");
        }
        else
        {
            foreach (var conta in contasPorAgencia)
            {
                Console.WriteLine(conta.ToString());
            }
        }
    }

}