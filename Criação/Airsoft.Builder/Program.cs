using Airsoft.Builder.Airsofts_Build;
using Airsoft.Builder;

//Criando diretor (representa a nota de aluguel)
var diretor = new NotaAluguelDiretor();

//Criando os itens a serem adicionados
var builderFuzil = new FuzilBuilder();
var builderPistola = new PistolalBuilder();

//Adicionando os itens na nota de aluguel
diretor.Builder = builderFuzil;
diretor.AddItemLista();
diretor.Builder = builderPistola;
diretor.AddItemLista();

//Imprimindo lista de itens alugados
Console.WriteLine("Lista de armas alugadas"); 
diretor.Itens.ForEach(i => Console.WriteLine(i.Nome));
//Imprimindo total do aluguel
Console.WriteLine($"Valor total: R$ {diretor.PrecoAluguel}");
//Funçao de pagamento
Console.WriteLine("Pagamento");
diretor.Pagamento(200.00);