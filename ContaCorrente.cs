namespace projeto_conta;


class ContaCorrente : Conta {
    public double Limite {get; set;}

    public override string Imprimir() 
    {
        string texto = base.Imprimir();

        texto += "\nLimite " + this.Limite;

        return texto;
    }
}
