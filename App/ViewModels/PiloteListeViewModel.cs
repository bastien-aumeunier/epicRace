using App.Models;
namespace App.ViewModels
{

    public class PiloteListeViewModel
    {
        public IEnumerable<PiloteCar> PiloteCarList { get; }
        public IEnumerable<Pilote> PiloteList { get; }
    
        public string HeaderTitle { get; }
        public PiloteListeViewModel(IEnumerable<Pilote> pilotes,IEnumerable<PiloteCar> piloteCarList ,string headerTitle)
        {
            PiloteList = pilotes;
            PiloteCarList = piloteCarList;

            HeaderTitle = headerTitle;
            
        }
    }
}