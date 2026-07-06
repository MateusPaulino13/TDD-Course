using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.DAL
{
    public interface IContatos
    {
        IContato Obter(Guid id);
    }
}
