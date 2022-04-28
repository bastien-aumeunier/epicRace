using App.Models;
using App.Data;

namespace App.ViewModels
{
    public class IndexViewModel
    {
        public List<Race> RaceList { get; }

        public string HeaderTitle { get; }
        public IndexViewModel(List<Race> races,string headerTitle)
        {
            
            Console.WriteLine("----------------------");
            RaceList = races.Where(race => race.EventDate > DateTime.Now).OrderBy(race => race.EventDate).Take(3).ToList();
            HeaderTitle = headerTitle;
            
        }
    }
}