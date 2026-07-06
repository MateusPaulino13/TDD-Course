using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domain
{
    public interface ITelefone
    {
        Guid Id { get; set; }
        string Numero { get; set; }
        Guid ContatoId { get; set; }
    }
}
