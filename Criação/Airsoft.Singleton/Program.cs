using Airsoft.Singleton;

var aluguel = AluguelAirsoft.GetInstancia();

aluguel.CriarAluguelFuzil();
aluguel.CriarAluguelPistolal();

//Retornando itens alugados
aluguel.Itens.ForEach(i => aluguel.ArmasAlugadas(i));
//Retornando preço total do aluguel
Console.WriteLine($"Valor total: {aluguel.PrecoAluguel}");
//Função de pagamento
aluguel.Pagamento(245.8);