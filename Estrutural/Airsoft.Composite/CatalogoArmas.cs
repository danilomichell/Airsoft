namespace Airsoft.Composite;

public class NotaAluguel
{
    private int _count;
    public NotaAluguel? Primeiro { get; set; }
    public ArmaAirsoft? Item { get; set; }
    public NotaAluguel? Filho { get; set; }

    private NotaAluguel CriarItem(ArmaAirsoft item)
    {
        var novoItem = new NotaAluguel
        {
            Item = item
        };
        return novoItem;
    }

    public void AddItem(NotaAluguel primeiro, ArmaAirsoft newGun)
    {
        while (true)
        {
            if (_count == 0)
            {
                Primeiro = CriarItem(newGun);
                Item = newGun;
                _count++;
            }
            else
            {
                if (primeiro.Filho is null)
                    primeiro.Filho = CriarItem(newGun);
                else
                {
                    primeiro = primeiro.Filho;
                    continue;
                }
            }

            break;
        }
    }

    public void RemoverItem(NotaAluguel item1, ArmaAirsoft item)
    {
        if (Primeiro!.Item == item)
            Primeiro = Primeiro.Filho;
        else
            RemoverItem(item1, item);
    }
}