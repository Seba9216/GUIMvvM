using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models
{
    public class ClickdatagridEvent : EventArgs
    {
        public Produkt Clicked { get; set; }




    }
    public delegate void TappedEventHandler(object sender, ClickdatagridEvent e); 
}
