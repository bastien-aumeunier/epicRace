using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class EFAccountRepository : IRepository<Pilote>
    {
        private readonly AppDbContext _dbContext;

        public EFAccountRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Pilote Add(Pilote model)
        {
            return _dbContext.Pilotes.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<Pilote> GetAll()
        {
            return _dbContext.Pilotes.Include(c => c.Cars).ToList();
        }

        public Pilote GetById(int id)
        {
            return _dbContext.Pilotes.Single(r => r.Id == id.ToString());
        }

        public Pilote GetById(string id)
        {
            return _dbContext.Pilotes.Single(r => r.Id == id);
        }
         public Pilote RemoveByid(int id)
        {
            Pilote pilote = _dbContext.Pilotes.Single(r => r.Id == id.ToString());
            _dbContext.Pilotes.Remove(pilote);
            return pilote;
        }
    }
}