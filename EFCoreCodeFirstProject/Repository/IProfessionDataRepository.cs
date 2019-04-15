using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstProject.Repository
{
   public interface IProfessionDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(long id);

        void Add(TEntity entity);

        void Update(TEntity dbEntity, TEntity entity);

        void Delete(TEntity entity);

    }
}
