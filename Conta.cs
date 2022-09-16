namespace projeto_conta
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }

        public virtual string Imprimir()
        {
            string texto;

            texto = "Agência "   + this.Agencia;
            texto += "\nNúmero " + this.Numero;
            texto += "\nSaldo "  + this.Saldo;
            
            return texto;
        }
    }
}