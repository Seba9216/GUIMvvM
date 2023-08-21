using GUIMvvM.Models;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace GUIMvvM.ViewModels
{
    public class DataGridProductViewModel : ViewModelBase
    {
        static ObservableCollection<Produkt>  products = new ObservableCollection<Produkt>();
        public  ObservableCollection<Produkt> Products
        {
            get => products;

            set => this.RaiseAndSetIfChanged(ref products, value, nameof(Products));
        }

        public  DataGridProductViewModel()
        {

            if (products.Count > 0) return; 
            var products1 = new ObservableCollection<Produkt>
            {
            new Produkt()
            {
                Navn = "Løbehjul",
                SalgsPris = 2000,
                IndKøbsPris = 15,
                Beskrivelse = "Et hjul der løber",
                Produktenhed = 5,
                Lagerantal = 69,
                Hidden = false,

            },
            new Produkt()
            {
                Navn = "Træsko",
                SalgsPris = 200,
                IndKøbsPris = 150,
                Beskrivelse = "Sko der lavet af træ",
                Produktenhed = 4,
                Lagerantal = 420,
                Hidden = false,

            },
             new Produkt()
            {
                Navn = "Halskæde",
                SalgsPris = 500,
                IndKøbsPris = 1,
                Beskrivelse = "Kæde til halsen",
                Produktenhed = 3,
                Lagerantal = 20,
                Hidden = false,

            },
            new Produkt()
            {
                Navn = "Baobabtræ",
                SalgsPris = 20,
                IndKøbsPris = 150,
                Beskrivelse = "Afrikansk træ",
                Produktenhed = 1,
                Lagerantal = 2,
                Hidden = false,

            },
           new Produkt()
            {
                Navn = "Motorsav",
                SalgsPris = 300,
                IndKøbsPris = 150,
                Beskrivelse = "Til at fælde baobabtræer",
                Produktenhed = 2,
                Lagerantal = 2,
                Hidden = false,


            }
           };

            products = new ObservableCollection<Produkt>(products1);
        }





    }
}
