using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
        where TContext : DbContext, new() //dbcontextten int. edilmesi lazım.., 
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //bu referansı yakalama
                addedEntity.State = EntityState.Added; //ekle
                context.SaveChanges(); //burdaki tüm işlemleri gerçekleştir
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //bu referansı yakalama
                deletedEntity.State = EntityState.Deleted; //silme
                context.SaveChanges(); //burdaki tüm işlemleri gerçekleştir
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

                //eğer filter null ise   context.Set<Product>().ToList() bu çalışacak eğer null değilse context.Set<Product>().Where(filter).ToList(); bu çalışacaktır...
                //bu yazım şekli thearry operatörü vs gibi birşeydi önceki ödevlerde var
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //bu referansı yakalama
                updatedEntity.State = EntityState.Modified; //güncelle
                context.SaveChanges(); //burdaki tüm işlemleri gerçekleştir
            }
        }
    }
}
