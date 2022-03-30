using Airsoft.Singleton;

var aluguel = AluguelAirsoft.GetInstancia();

aluguel.CriarAluguelFuzil();
aluguel.CriarAluguelPistolal();

//Retornando itens alugados
aluguel.Itens.ForEach(i => aluguel.ArmasAlugadas(i));
//Retornando iformações de pagamento
Console.WriteLine("--------------------------------------------------------------");
aluguel.StatusNota();
//Função de pagamento
Console.WriteLine();
aluguel.Pagamento(1,245.8,3);
Console.WriteLine("--------------------------------------------------------------");
//Retornando status da nota
aluguel.StatusNota();