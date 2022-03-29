using Airsoft.Singleton;

var aluguel = AluguelAirsoft.GetInstancia();

aluguel.CriarAluguelFuzil();
aluguel.CriarAluguelPistolal();

//Retornando itens alugados
aluguel.Itens.ForEach(i => aluguel.ArmasAlugadas(i));
//Retornando iformações de pagamento
Console.WriteLine("-------------------------------------");
aluguel.StatusNota();
//Função de pagamento
aluguel.Pagamento(245.8);
Console.WriteLine("-------------------------------------");
//Retornando status da nota
aluguel.StatusNota();