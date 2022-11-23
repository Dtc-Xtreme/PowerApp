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
    public partial class HomeViewModel : BaseViewModel
    {
        private VerbruikElectriciteitViewModel electricityVM;
        private VerbruikWaterViewModel waterVM;
        private VerbruikGasViewModel gasVM;

        //private int totalKwh;
        //private int totalLiters;

        //public int TotalKwh
        //{
        //    get { return totalKwh; }
        //    set
        //    {
        //        SetProperty(ref totalKwh, value);
        //        CheckSmileyForKwh();
        //    }
        //}
        //public int TotalLiters
        //{
        //    get { return totalLiters; }
        //    set
        //    {
        //        SetProperty(ref totalLiters, value);
        //        CheckSmileyForLiters();
        //    }
        //}

        //[ObservableProperty]
        //private bool isSmilingKwh;

        //[ObservableProperty]
        //private bool isSmilingLiters;

        //[ObservableProperty]
        //private Color backgroundColorKwh;

        //[ObservableProperty]
        //private Color backgroundColorLiters;

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

        //private void CheckSmileyForKwh()
        //{
        //    if (totalKwh <= 2479)
        //    {
        //        IsSmilingKwh = true;
        //        BackgroundColorKwh = Color.Parse("#1ed822");
        //    }
        //    else
        //    {
        //        IsSmilingKwh = false;
        //        BackgroundColorKwh = Color.Parse("#d02a22");
        //    }
        //}
        //private void CheckSmileyForLiters()
        //{
        //    if (TotalLiters <= 2479)
        //    {
        //        IsSmilingLiters = true;
        //        BackgroundColorLiters = Color.Parse("#1ed822");
        //    }
        //    else
        //    {
        //        IsSmilingLiters = false;
        //        BackgroundColorLiters = Color.Parse("#d02a22");
        //    }
        //}

        //[RelayCommand]
        //private void Toggle()
        //{
        //    if(TotalKwh == 2453)
        //    {
        //        TotalKwh = 3900;
        //        TotalLiters = 2174;
        //    }
        //    else
        //    {
        //        TotalKwh = 2453;
        //        TotalLiters = 4850;
        //    }

        //}
    }
}
