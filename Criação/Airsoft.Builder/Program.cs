using Airsoft.Builder;

var diretor = new ArmaDirector();

var builder1 = new ArmaBuilder();

//diretor.Construct(builder1, "MPW 12", 2019, 100, "G&G", "EUA","Fuzil assalto",50);
diretor.FuzilConstruct(builder1);
Console.WriteLine(diretor.ReturnAirsoft(builder1).Nome);