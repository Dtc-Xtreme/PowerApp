using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.Models
{
    public partial class Water : ObservableObject
    {
        private const int goodNr = 3000;    // x montly

        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private int liters;

        [ObservableProperty]
        private string label;

        public Water(int id, int liters, string label)
        {
            this.id = id;
            this.liters = liters;
            this.label = label;
        }

        public override string ToString()
        {
            return this.liters + " liters " + "(" + label + ")";
        }

        // We use these getters for displaying in the View
        public string PrintLine
        {
            get
            {
                return "Je hebt " + this.liters + " liter verbruikt in " + this.label + ".";
            }
        }
        public bool IsGood
        {
            get
            {
                return goodNr <= this.liters ? true : false;
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
