using Airsoft.Composite;
using Airsoft.Composite.Armas;

// Criando um alugel
var aluguel1 = new NotaAluguel();

//Adicionando uma airsoft na nota do aluguel
aluguel1.CriarNota(1,1,true, true , true, 2);
aluguel1.CriarNota(2,3,false,false,false, 3);

//Exibindo o valor total do aluguel
Console.WriteLine($"Total do aluguel: R$ {aluguel1.ValorTotal}");

//Imprindo a lista de produtos alugados
aluguel1.Itens.ForEach(p => Console.WriteLine($"Armas alugadas: {p.Plataforma.Nome}"));