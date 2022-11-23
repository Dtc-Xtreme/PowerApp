using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PowerApp.Models;
using PowerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.ViewModels
{
    public partial class VerbruikGasViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Gas> list;

        private Gas selectedItem;

        public Gas SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref selectedItem, value);
                    Navigate();
                }
            }
        }

        public VerbruikGasViewModel()
        {
            list = new List<Gas>(){
                new Gas(1,500,"Januari"),
                new Gas(2,1100,"Februari"),
                new Gas(3,2000,"Maart"),
                new Gas(4,1200,"April"),
                new Gas(5,974,"Mei"),
                new Gas(6,1081,"Juni"),
                new Gas(7,1007,"Juli"),
                new Gas(8,907,"Augustus"),
                new Gas(9,897,"September"),
                new Gas(10,1050,"Oktober"),
                new Gas(11,970,"November"),
                new Gas(12,0,"December")
            };
        }

        private async void Navigate()
        {
            var args = new Dictionary<string, object>
            {
                {"SelectedGas", SelectedItem}
            };
            await Shell.Current.GoToAsync(nameof(HomePage), args);
        }
    }
}
