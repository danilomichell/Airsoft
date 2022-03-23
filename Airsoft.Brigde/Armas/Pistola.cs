﻿using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.Armas;

public class Pistola : Armas
{
    public Pistola(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo,
        fabrica, preco, ano)
    {
    }
}