﻿using Airsoft.Composite;
using Airsoft.Composite.Armas;

var aluguel = new NotaAluguel();
var arma = new Arma();

var arma1 = arma.AdicionarRifle();
var arma2 = arma.AdicionarPistola();
var arma3 = arma.AdicionarSniper();

aluguel.AddItem(null!, arma1);
aluguel.AddItem(aluguel.Primeiro!, arma2);
aluguel.AddItem(aluguel.Primeiro!, arma3);


//Console.WriteLine($"Nome da arma: {catalogo.Item.Nome}");
//Console.WriteLine($"Ano: { catalogo.Item.Ano}");
//Console.WriteLine($"Preço: R${catalogo.Item.Preco}");
//Console.WriteLine($"Fabricante: {catalogo.Item.Fabricante}");
//Console.WriteLine($"País: {catalogo.Item.Pais}");
//Console.WriteLine($"Tipo da arma: {catalogo.Item.Tipo}");
//Console.WriteLine($"Distância em metros: {catalogo.Item.Distancia}m");

aluguel.RemoverItem(aluguel.Primeiro!, arma1);
Console.WriteLine(aluguel.Primeiro!.Item!.Nome);
