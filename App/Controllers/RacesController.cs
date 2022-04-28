using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RacesController : Controller
    {
        private readonly IRepository<Race> _raceRepository;

        public RacesController(IRepository<Race> raceRepository)
        {
            _raceRepository = raceRepository;
        }
        // GET: Races
        public ActionResult Index()
        {
            var races = _raceRepository.GetAll();
            var raceListViewModel = new RaceListViewModel(
                races,
                "Liste de courses"
            );

            return View("RaceList", raceListViewModel);
        }

        // GET: Races/
        public ActionResult List()
        {
            return Ok("LIST ACTION CALLED !");
        }

        // GET: Races/Details/5
        public ActionResult Details(int id)
        {
            var race = _raceRepository.GetById(id);

            var raceDetailViewModel = new DetailRaceViewModel(
                race,
                "Détails"
            );

            return View("DetailRace", raceDetailViewModel);
        }

        // GET: Races/Create
        public ActionResult Create()
        {

            return View("CreateRace");
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaceRequest race)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    Race newRace = new()
                    {
                        Name = race.RaceName,
                        EventDate = race.RaceDate,
                        Places = race.NumberOfPlaces,
                        Age = race.Age,
                        Latitude = race.Latitude,
                        Longitude = race.Longitude,
                    };

                    _raceRepository.Add(newRace);
                    _raceRepository.Commit();

                    return RedirectToAction(nameof(Index));
                }
                return View("CreateRace");
            }
            catch
            {
                return View("CreateRace");
            }
        }

        // GET: Races/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Races/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}