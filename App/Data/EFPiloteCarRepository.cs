using App.Models;


namespace App.Data
{
    public class EFPiloteCarRepository
    {
        private readonly AppDbContext _dbContext;

        public EFPiloteCarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public PiloteCar Add(PiloteCar model)
        {
            return _dbContext.PiloteCars.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<PiloteCar> GetAll()
        {
            return _dbContext.PiloteCars.ToList();
        }

        public PiloteCar GetByPilotId(int id)
        {
            return _dbContext.PiloteCars.Single(r => r.Id == id);
        }

        public PiloteCar RemoveByid(int id)
        {
            PiloteCar piloteCar = _dbContext.PiloteCars.Single(r => r.Id == id);
            _dbContext.PiloteCars.Remove(piloteCar);
            return piloteCar;
        }
    }
}