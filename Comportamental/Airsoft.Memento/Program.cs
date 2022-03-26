using Airsoft.Memento;

var nota1 = new NotaAluguel();

nota1.AddAirsoftNota(1);
nota1.AddAirsoftNota(2);
Console.WriteLine(nota1.PrecoPedido);
var memento = nota1.CriarMemento();
nota1.AddAirsoftNota(3);
Console.WriteLine(nota1.PrecoPedido);
nota1.RetornarStatusAnterior(memento);
Console.WriteLine(nota1.PrecoPedido);
nota1.Pagamento(1000.0);
if (nota1.Status){
    Console.WriteLine("Pago");
}
else
{
    Console.WriteLine("Em aberto");
}
