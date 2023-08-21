using GUIMvvM.Models.Veichles.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models.Veichles.Busses
{
    public class Busses : Base_CommerceVehicle
    {
        public override byte Drivers_license { get; set ; }

        public byte Amount_Of_Seats { get; set ; }

        public byte Amount_Of_Sleeping_Places { get; set; }

        public bool Has_Toilet { get; set; }
        public override double Height { get; set ; }
        public override double Width { get; set; }
        public override double Lenght { get; set; }
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
