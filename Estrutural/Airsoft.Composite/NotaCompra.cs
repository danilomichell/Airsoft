using Airsoft.Composite.Armas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Airsoft.Composite;

public class NotaAluguel
{
    public List<Kit> Itens;
    public double ValorTotal { get; set; }

    public NotaAluguel()
    {
        Itens = new List<Kit>();
    }

    public void CriarNota(int classe, int modelo, bool mira, bool silenciador, bool colete, int pistola)
    {
        Itens.Add(AddAirsoftNota(classe, modelo, mira, silenciador, colete, pistola));
    }

    private Kit AddAirsoftNota(int classe, int modelo, bool mira, bool silenciador, bool colete, int pistola)
    {
        var Kit = new Kit();
        switch (classe)
        {
            case 1:
                var fuzil = new AirsoftRifle();
                Kit = fuzil.CriarKitAssalt(modelo, mira, silenciador, colete, pistola);
                ValorTotal += Kit.PrecoKit;
                break;

            case 2:
                var sniper = new AirsoftFuzilPrecisao();
                Kit = sniper.CriarKitSniper(modelo, mira, colete, pistola);
                ValorTotal += Kit.PrecoKit;
                break;
        }

        return Kit;

    }
}