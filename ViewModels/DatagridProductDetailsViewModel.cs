using GUIMvvM.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.ViewModels
{
    public class DatagridProductDetailsViewModel : ViewModelBase
    {
        public List<Produkt> Product { get; set; } = new List<Produkt>();



        private Produkt _produkt;
        public Produkt Produkt
        {
            get
            {
                return _produkt;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _produkt, value, nameof(Produkt));
            }
        }



        public DatagridProductDetailsViewModel()
        {




        }





    }
}
