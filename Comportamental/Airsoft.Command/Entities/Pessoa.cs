using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Command.Entities
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
