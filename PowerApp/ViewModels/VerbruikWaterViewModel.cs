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
    public partial class VerbruikWaterViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Water> list;

        private Water selectedItem;

        public Water SelectedItem
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

        public VerbruikWaterViewModel()
        {
            list = new List<Water>(){
                new Water(1,5321,"Januari"),
                new Water(2,4143,"Februari"),
                new Water(3,4805,"Maart"),
                new Water(4,5105,"April"),
                new Water(5,6000,"Mei"),
                new Water(6,5000,"Juni"),
                new Water(7,4200,"Juli"),
                new Water(8,3800,"Augustus"),
                new Water(9,3701,"September"),
                new Water(10,4100,"Oktober"),
                new Water(11,4541,"November"),
                new Water(12,0,"December")
            };
        }

        private async void Navigate()
        {
            var args = new Dictionary<string, object>
            {
                {"SelectedWater", SelectedItem}
            };
            await Shell.Current.GoToAsync(nameof(HomePage), args);
        }
    }
}
