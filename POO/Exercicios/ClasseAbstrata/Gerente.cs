class Gerente : Funcionario
{

    public Gerente(string nome, double Salario) : base(nome, Salario) { }
    public override double calcularBonificacao()
    {
        return Salario * 0.2;
    }
}