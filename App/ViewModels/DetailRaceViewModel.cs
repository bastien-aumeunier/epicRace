using App.Models;

namespace App.ViewModels
{
    public class DetailRaceViewModel
    {
        public Race Race { get; }
        public string HeaderTitle { get; }
        public DetailRaceViewModel(Race race, string headerTitle)
        {
            Race = race;
            HeaderTitle = headerTitle;
        }
    }
}