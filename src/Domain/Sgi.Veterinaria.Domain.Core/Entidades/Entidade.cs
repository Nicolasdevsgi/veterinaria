using System;

namespace Sgi.Veterinaria.Domain.Core.Entidades
{
    public abstract class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            Excluido = false;
        }

        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public bool Excluido { get; protected set; }
    }
}
