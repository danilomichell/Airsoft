using Airsoft.Memento;

var nota1 = new NotaAluguel();

//Criando adicionando armas na nota 
nota1.AddAirsoftNota(1);
nota1.AddAirsoftNota(2);
Console.WriteLine(nota1.PrecoPedido);
Console.WriteLine();

//Salvando a nota
var NotaSalva = nota1.CriarMemento();

//Adicionando um item errado na nota
nota1.AddAirsoftNota(3);
Console.WriteLine(nota1.PrecoPedido);
Console.WriteLine();

//Retornando ao ultimo save da nota
nota1.RetornarNotaAnterior(NotaSalva);
Console.WriteLine(nota1.PrecoPedido);
Console.WriteLine();

//Itens alugados
Console.WriteLine("Itens alugados:");
nota1.Pedido.ForEach(p => Console.WriteLine(p.Nome));
Console.WriteLine($"Data do aluguel: {nota1.DiaAluguel}");
Console.WriteLine();

//Testando método de pagamento
//(0 - pagamento avista/ 1 - pagamento parcelado || valor caso seja pagamento a vista - pagamento prcelado bota 0 || quantidade de vezes - pagamento a vista bota 0)
nota1.Pagamento(1,0,4);


