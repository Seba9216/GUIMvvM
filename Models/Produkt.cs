using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models
{
    public class Produkt
    {
        public string Navn
        {
            get
            {
                return navn;
            }
            set {
                navn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Navn)));
            }
        }

        private string navn { get; set; }


        public double SalgsPris
        {
            get
            {
                return salgsPris;
            }
            set {

                salgsPris = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SaglsPris"));

            }
        }

        private double salgsPris { get; set; }


        public double IndKøbsPris
        {
            get
            {
                return indKøbsPris;
            }
            set {

                indKøbsPris = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("indkøbspris"));

            }
        }
        private double indKøbsPris { get; set; }


        public string Beskrivelse
        {
            get
            {
                return beskrivelse;
            }
            set {

                beskrivelse = value;
                PropertyChanged?.Invoke(beskrivelse, new PropertyChangedEventArgs("Beskrivelse"));
            }
        }

        private string beskrivelse { get; set; }

        public uint Lagerantal
        {
            get
            {
                return lagerantal;
            }
            set {

                lagerantal = value;
                PropertyChanged?.Invoke(lagerantal, new PropertyChangedEventArgs("Antal"));
            }
        }

        private uint lagerantal { get; set; }


        public uint Produktenhed
        {
            get
            {
                return produktenhed;
            }
            set {


                produktenhed = value;
                PropertyChanged?.Invoke(produktenhed, new PropertyChangedEventArgs("Enhed"));

            }
        }

        private uint produktenhed { get; set; }


        public bool Hidden
        {
            get
            {
                return hidden;
            }
            set {

                hidden = value;
                PropertyChanged?.Invoke(hidden, new PropertyChangedEventArgs("HIdden"));
            }
        }

        private bool hidden { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
