using Airsoft.Singleton;

var aluguel = AluguelAirsoft.GetInstancia();

var aluguel1 = aluguel.CriarAluguelFuzil();
var aluguel2 = aluguel.CriarAluguelPistolal();
var aluguel3 = aluguel.CriarAluguelFuzilPrecisao();

aluguel.ArmasAlugadas(aluguel1);
aluguel.ArmasAlugadas(aluguel2);
aluguel.ArmasAlugadas(aluguel3);
