using HouseRentApp.Models;

namespace HouseRentApp.ViewModels
{
    public class ApartmentListViewModel
    {
        public IEnumerable<Apartment> Apartments;
        public string CurrentViewModelName;


        public ApartmentListViewModel(IEnumerable<Apartment> Apartments, string CurrentViewModelName)
        {
            Apartments = Apartments;
            CurrentViewModelName = CurrentViewModelName;
        }
    }
}
