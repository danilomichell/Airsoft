using Airsoft.Iterator;

Armas a1 = new("GPT-9", 75, 2000);
Armas a2 = new("M1911", 750, 2014);
Armas a3 = new("M4", 1200, 2020);

Site site = new Site();
site.AddArma(a1);
site.AddArma(a2);
site.AddArma(a3);

site.PrintLista();

site.RemoveArma();

Console.WriteLine("--------");

site.PrintLista();

Console.WriteLine("--------");
Iterator iterator =  site.CreateIterator();

while (iterator.HasNext())
{
    Armas arma = iterator.Next();
    Console.WriteLine(arma.ArmaToString());
}