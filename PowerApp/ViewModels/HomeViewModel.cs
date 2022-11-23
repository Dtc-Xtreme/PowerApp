using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.ViewModels
{
    [QueryProperty(nameof(SelectedElectricity), "SelectedElectricity")]
    [QueryProperty(nameof(SelectedWater), "SelectedWater")]
    [QueryProperty(nameof(SelectedGas), "SelectedGas")]
    public partial class HomeViewModel : BaseViewModel
    {
        private VerbruikElectriciteitViewModel electricityVM;
        private VerbruikWaterViewModel waterVM;
        private VerbruikGasViewModel gasVM;

        [ObservableProperty]
        private Electriciteit selectedElectricity;

        [ObservableProperty]
        private Water selectedWater;

        [ObservableProperty]
        private Gas selectedGas;

        public HomeViewModel(VerbruikElectriciteitViewModel elecVM, VerbruikWaterViewModel waterVM, VerbruikGasViewModel gasVM)
        {
            this.electricityVM = elecVM;
            this.waterVM = waterVM;
            this.gasVM = gasVM;

            //TotalKwh = 2453;
            //TotalLiters = 2174;

            SelectedElectricity = elecVM.List.LastOrDefault(c=>c.Kwh != 0);
            SelectedWater = waterVM.List.LastOrDefault(c => c.Liters != 0);
            SelectedGas = gasVM.List.LastOrDefault(c => c.Kwh != 0);
        }

        [RelayCommand]
        private void Toggle()
        {
        }
    }
}
