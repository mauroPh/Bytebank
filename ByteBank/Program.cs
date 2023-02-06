using ByteBank;

ContaCorrente contaDoWayne = new ContaCorrente();
contaDoWayne.titular = "Bruce Wayne";
contaDoWayne.numero_agencia = 15;
contaDoWayne.conta = "1010-x";
contaDoWayne.saldo = 30000000000;

Console.WriteLine("Saldo da conta do Bruce Wayne é = " + contaDoWayne.saldo);

contaDoWayne.Depositar(150);
Console.WriteLine("Saldo da conta do Bruce Wayne após o depósito é de = " + contaDoWayne.saldo);

if (contaDoWayne.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do Bruce Wayne  após o saque é de = " + contaDoWayne.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para este saque.");
}

ContaCorrente contaDoStark = new ContaCorrente();
contaDoStark.titular = "Tony Stark";
contaDoStark.numero_agencia = 17;
contaDoStark.conta = "2020-x";
contaDoStark.saldo = 29999999750;
Console.WriteLine("--------------------------------------");
Console.WriteLine("Saldo Bruce Wayne =" + contaDoWayne.saldo);
Console.WriteLine("Saldo Tony Stark=" + contaDoStark.saldo);

contaDoWayne.Transferir(50, contaDoStark);
Console.WriteLine( "Transferência de R$50,00 efetuada com sucesso!");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Saldo Bruce Wayne =" + contaDoWayne.saldo);
Console.WriteLine("Saldo Tony Stark=" + contaDoStark.saldo);


ContaCorrente contaDoLuthor = new ContaCorrente();

Console.WriteLine(contaDoLuthor.titular);
Console.WriteLine(contaDoLuthor.saldo);
Console.WriteLine(contaDoLuthor.conta);


Console.WriteLine(contaDoWayne.ExibirDadosDaConta);


