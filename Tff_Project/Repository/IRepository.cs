using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff_Project.Models;

namespace Tff_Project.Repository;

public interface IRepository<TEntity,TId>
    where TEntity : Entity<TId>, new()
{
    TEntity? GetById(TId id);
    List<TEntity> GetAll();

    TEntity Add(TEntity entity);

    TEntity? Update(TId id, TEntity entity);
    TEntity? Delete(TId id);
}
