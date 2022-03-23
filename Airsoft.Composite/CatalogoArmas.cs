namespace Airsoft.Composite;

public class NotaAluguel
{
    private int count;
    public NotaAluguel? Primeiro { get; set; }
    public ArmaAirsoft? Item { get; set; }
    public NotaAluguel? Filho { get; set; }

    private NotaAluguel criarItem(ArmaAirsoft item)
    {
        var novoItem = new NotaAluguel();
        novoItem.Item = item;
        return novoItem;
    }

    public void AddItem(NotaAluguel primeiro, ArmaAirsoft newGun)
    {
        if (count == 0)
        {
            Primeiro = criarItem(newGun);
            Item = newGun;
            count++;
        }
        else
        {
            if (primeiro.Filho is null)
                primeiro.Filho = criarItem(newGun);
            else
                AddItem(primeiro.Filho, newGun);
        }
    }

    public void RemoverItem(NotaAluguel item1, ArmaAirsoft item)
    {
        if (Primeiro.Item == item)
            Primeiro = Primeiro.Filho;
        else
            RemoverItem(item1, item);
    }
}