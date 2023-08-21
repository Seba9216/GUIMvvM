using GUIMvvM.Models.Veichles.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models.Veichles.Trucks
{
    public class Truck : Base_CommerceVehicle
    {
        public override byte Drivers_license { get; set; } = 3; 

        public override double Height { get; set; }
        public override double Width { get; set; }
        public override double Lenght { get; set; }
        public double LoadCapacity { get; set; }
        public override bool TowHook { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override char Calculate_Engergy_Class()
        {
            return 'A';
        }

        public override string ToString()
        {
            return ""; 
        }
    }
}
