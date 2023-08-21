using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models.Veichles
{
    public abstract class Veichle
    {
        public virtual string Name { get; set; }

        public virtual uint Driven_Kilometers { get; set; }

        public virtual string LicensePlate { get; set; }

        public virtual DateTime RegistrationDate { get; set; }

        public virtual decimal Production_Price { get; set; }

        public abstract bool TowHook { get; set; }

        public abstract byte Drivers_license { get; set; }

        public virtual double Engine_Size { get; set; }

        public virtual double Kilometers_Per_Liter { get; set; }

        public virtual bool FuelType { get; set; }

        public char Energy_Class { get; set; }



        public abstract char Calculate_Engergy_Class();

        public abstract string ToString();
        
    }

    public class Class1
    {
    }
}
