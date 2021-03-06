using Airsoft.Composite;
using Airsoft.Composite.Armas;

// Criando um alugel
var aluguel1 = new NotaAluguel();

//Adicionando uma airsoft na nota do aluguel - oredem do método: (classe de airsoft - modelo de airsoft - se vai ter mira - se vai ter colete - se vai ter ilenciador - modelo da pistola)
aluguel1.CriarNota(1,1,true, true , true, 2);
aluguel1.CriarNota(2,3,false,false,false, 3);

//Imprindo a lista de produtos alugados
aluguel1.Itens.ForEach(p => Console.WriteLine($"Armas alugadas: {p.Plataforma.Nome}"));
Console.WriteLine($"Data: {aluguel1.DiaAluguel}");
Console.WriteLine();

//Exibindo o valor total do aluguel
Console.WriteLine($"Total do aluguel: R$ {aluguel1.ValorTotal}");
Console.WriteLine("------------------------------------------------------------");
//Pagamendo o aluguel
aluguel1.Pagamento(1,0,4);