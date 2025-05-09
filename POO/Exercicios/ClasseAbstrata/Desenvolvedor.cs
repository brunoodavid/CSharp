class Desenvolvedor : Funcionario
{

    public Desenvolvedor(string nome, double salario) : base(nome, salario) { }
    public override double calcularBonificacao()
    {
        return Salario * 0.1;
    }
}