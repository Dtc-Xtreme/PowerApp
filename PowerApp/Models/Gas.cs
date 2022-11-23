using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.Models
{
    public partial class Gas : ObservableObject
    {
        private const int goodNr = 3000;    // x montly

        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private int kwh;

        [ObservableProperty]
        private string label;

        public Gas(int id, int kwh, string label)
        {
            this.id = id;
            this.kwh = kwh;
            this.label = label;
        }

        public override string ToString()
        {
            return this.kwh + " kWh " + "(" + label + ")";
        }

        // We use these getters for displaying in the View
        public string PrintLine
        {
            get
            {
                return "Je hebt " + this.kwh + " kWh verbruikt in " + this.label + ".";
            }
        }
        public bool IsGood
        {
            get
            {
                return goodNr <= this.kwh ? true : false;
            }
        }
        public Color GetColor
        {
            get
            {
                return IsGood ? Color.FromHex("1ed822") : Color.FromHex("d02a22");
            }
        }
    }
}
