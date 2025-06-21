using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;

namespace AgendaApp.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        void Add(Tarefa tarefa);
        void Update(Tarefa tarefa);
        void Delete(Guid id);

        List<Tarefa>? FindAll(DateOnly dateMin,DateOnly dateMax,Guid usuarioId);
        Tarefa? FindById(Guid id, Guid usuarioId);
    }
}
