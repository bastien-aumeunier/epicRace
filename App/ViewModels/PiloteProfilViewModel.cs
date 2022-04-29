using App.Models;
namespace App.ViewModels
{
    public class PiloteProfilViewModel
    {
        public PiloteCar PiloteCarList { get; }
        public Pilote Pilote { get; }
    
        public string HeaderTitle { get; }
        public PiloteProfilViewModel(Pilote pilotes,PiloteCar piloteCarList ,string headerTitle)
        {
            Pilote = pilotes;
            PiloteCarList = piloteCarList;

            HeaderTitle = headerTitle;
            
        }
    }
}