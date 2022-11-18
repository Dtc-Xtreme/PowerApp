using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private int number;

        [ObservableProperty]
        private bool isSmiling;

        public HomeViewModel()
        {
            Number = 1900;
            CheckSmiley();
        }

        private void CheckSmiley()
        {
            if (Number <= 2479)
            {
                IsSmiling = true;
            }
            else
            {
                IsSmiling = false;
            }
        }
    }
}
