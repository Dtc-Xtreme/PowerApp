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
    public partial class VerbruikElectriciteitViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Electriciteit> list;

        public VerbruikElectriciteitViewModel()
        {
            list = new List<Electriciteit>(){
                new Electriciteit(1,1000,"Januari"),
                new Electriciteit(2,900,"Februari"),
                new Electriciteit(3,1100,"Maart"),
                new Electriciteit(4,1200,"April"),
                new Electriciteit(5,850,"Mei"),
                new Electriciteit(6,1187,"Juni"),
                new Electriciteit(7,1202,"Juli"),
                new Electriciteit(8,1170,"Augustus"),
                new Electriciteit(9,1025,"September"),
                new Electriciteit(10,950,"Oktober"),
                new Electriciteit(11,850,"November"),
                new Electriciteit(12,0,"December")
            };
        }

        public void GaNaarWebPagina()
        {
            
        }
    }
}
