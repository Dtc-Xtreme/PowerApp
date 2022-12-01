using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.Models
{
    public partial class Tip : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private string image;

        public Tip()
        {

        }

        public Tip(int id, string title, string text, string image = null)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.image = image;
        }
    }
}
