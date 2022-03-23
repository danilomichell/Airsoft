using Airsoft.Composite;
using Airsoft.Composite.Armas;

var aluguel = new NotaAluguel();
var arma = new Arma();

var arma1 = arma.AdicionarRifle();
var arma2 = arma.AdicionarPistola();
var arma3 = arma.AdicionarSniper();

aluguel.AddItem(null!, arma1);
aluguel.AddItem(aluguel.Primeiro!, arma2);
aluguel.AddItem(aluguel.Primeiro!, arma3);

aluguel.RemoverItem(aluguel.Primeiro!, arma1);
Console.WriteLine(aluguel.Primeiro!.Item!.Nome);
