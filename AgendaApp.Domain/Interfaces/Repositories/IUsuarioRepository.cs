using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;

namespace AgendaApp.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);

        Usuario? Find(Guid id);

        Usuario? Find(string email, string senha);

        bool Any(string email);
    }
}
