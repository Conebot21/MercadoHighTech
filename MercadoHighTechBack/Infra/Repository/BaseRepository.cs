using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public interface BaseRepository<TEntidades>
    {
        public void Add(TEntidades entidade);
        public void Delete(int id);
        public void Update(TEntidades entidade);
        public IEnumerable<TEntidades> Get();
    }
}
