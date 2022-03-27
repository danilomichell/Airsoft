using Airsoft.Memento;

var nota1 = new NotaAluguel();

//Criando adicionando armas na nota 
nota1.AddAirsoftNota(1);
nota1.AddAirsoftNota(2);
Console.WriteLine(nota1.PrecoPedido);

//Salvando a nota
var NotaSalva = nota1.CriarMemento();

//Adicionando um item errado na nota
nota1.AddAirsoftNota(3);
Console.WriteLine(nota1.PrecoPedido);

//Retornando ao ultimo save da nota
nota1.RetornarNotaAnterior(NotaSalva);
Console.WriteLine(nota1.PrecoPedido);

//Testando método de pagamento
nota1.Pagamento(1000.0);
if (nota1.Status){
    Console.WriteLine("Pago");
}
else
{
    Console.WriteLine("Em aberto");
}
