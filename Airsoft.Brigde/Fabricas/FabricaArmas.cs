﻿using Airsoft.Bridge.Armas;
using Airsoft.Bridge.ArmasEnidades;
using Airsoft.Brigde.Fabricas;

#pragma warning disable CS8618
namespace Airsoft.Bridge.Fabricas
{
    public class FabricaArmas : IFabricaArmas
    {
        public string Nome { get; set; }

        public Rifle CriarRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new M4A1(nome, tipo, fabrica, preco, data);
        }

        public Pistola CriarPistola(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new GTP9(nome, tipo, fabrica, preco, data);
        }

        public AssaultRifle CriarAssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new CM16(nome, tipo, fabrica, preco, data);
        }

    }
}
