using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Memento
{
    public class NotaMemento
    {
        public NotaMemento(List<AirsoftItem> pedido, bool status, double precoPedido)
        {
            this.Pedido = pedido;
            Status = status;
            PrecoPedido = precoPedido;
        }

        public List<AirsoftItem> Pedido;
        public bool Status { get; set; }
        public double PrecoPedido { get; set; }

        public bool RetornarStatusAnterior()
        {
            return Status;
        }
        public List<AirsoftItem> RetornarListaAnterior()
        {
            return Pedido;
        }
        public double RetornarPrecoAnterior()
        {
            return PrecoPedido;
        }
    }
}
