using GUIMvvM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.ViewModels
{
    public class DatagridProductDetailsViewModel : ViewModelBase
    {
        public List<Produkt> Product { get; set; } = new List<Produkt>();

        
        public DatagridProductDetailsViewModel(Produkt produkt)      
        { 
            Product.Add(produkt);



        }





    }
}
