using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class PiloteController  : Controller
    {
        private readonly IRepository<Pilote> _piloteRepository;
        private readonly IRepository<PiloteCar> _pilotaCarRepository;

        public PiloteController(IRepository<Pilote> piloteRepository, IRepository<PiloteCar> pilotaCarRepository)
        {
            _piloteRepository = piloteRepository;
            _pilotaCarRepository = pilotaCarRepository;
        }

        public ActionResult Index()
        {
            var pilotes = _piloteRepository.GetAll();
            var car = _pilotaCarRepository.GetAll();
            var piloteListeViewModel = new PiloteListeViewModel(
                pilotes,
                car,
                "Liste des Pilotes"
            );
            return View("PiloteList", piloteListeViewModel);
        }

        public ActionResult Profile(int id)
        {
            var pilote = _piloteRepository.GetById(id);
            var car = _pilotaCarRepository.GetById(id);

            var piloteProfilViewModel = new PiloteProfilViewModel(
                pilote,
                car,
                "Détail"
            );
            return View("PiloteProfil", piloteProfilViewModel);
        }
    }
}