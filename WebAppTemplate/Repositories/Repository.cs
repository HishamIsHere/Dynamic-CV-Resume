using Microsoft.EntityFrameworkCore;
using WebAppTemplate.Data;
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        DataDbContext DbContext;
        DbSet<T> DbSet;

        public Repository(DataDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            entity.IsActive = true;
            entity.CreateDate = DateTime.Now.ToString();
            DbSet.Add(entity);
            DbContext.SaveChanges();
        }

        public void ChangeStatus(int id)
        {
            var entity = GetById(id);
            entity.IsActive = !entity.IsActive;
            DbSet.Update(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            DbSet.Remove(entity);
            DbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return DbSet.Where(x => !x.IsDelete).ToList();
        }

        public List<T> GetAllClient()
        {
            return DbSet.Where(x => !x.IsDelete && x.IsActive).ToList();
        }

        public T GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id && !x.IsDelete);
        }

        public void Update(T entity)
        {
            // Add
            // Update
            // Get
            entity.UpdateDate = DateTime.Now.ToString();
            entity.IsActive = true;
            DbSet.Update(entity);
            DbContext.SaveChanges();
        }
    }
}
