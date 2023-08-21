using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models.Veichles.Base_Classes
{
    public abstract class Base_CommerceVehicle : Veichle
    {
        public abstract double Height { get; set; }
        public abstract double Width { get; set; }

        public abstract double Lenght { get; set; }
    }
}
