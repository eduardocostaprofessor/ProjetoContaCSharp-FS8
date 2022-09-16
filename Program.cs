using projeto_conta;//import/workspace

// See https://aka.ms/new-console-template for more information

//criando os objetos
ContaCorrente cCorrente = new ContaCorrente();
ContaPoupanca cPoupanca = new ContaPoupanca();

//preechendo os dados da classe

//Conta Corrente
cCorrente.Agencia = "5543";
cCorrente.Numero = "123";
cCorrente.Saldo = 1000.95;
cCorrente.Limite = 10000;

//Conta Poupança
cPoupanca.Agencia = "777876";
cPoupanca.Numero = "111";
cPoupanca.Saldo = 20000;
cPoupanca.Aniversario = "20";

//exibindo os dados do objeto
Console.WriteLine("***cCorrente***");
Console.WriteLine( cCorrente.Imprimir() );

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("***cPoupanca***");
Console.WriteLine( cPoupanca.Imprimir() );