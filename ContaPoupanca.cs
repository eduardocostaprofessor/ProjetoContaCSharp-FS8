namespace projeto_conta;

class ContaPoupanca : Conta {
    public string Aniversario {get; set;}

    public override string Imprimir() 
    {
        string texto = base.Imprimir();
        
        texto += "\nAniversário " + this.Aniversario;
        
        return texto;
    }
}
