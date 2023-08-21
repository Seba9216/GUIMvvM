using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIMvvM.Models.Veichles.Base_Classes;

namespace GUIMvvM.Models.Veichles.Cars
{
    public class PassengerCar : Base_Car
    {
        public override byte Drivers_license { get; set; }

        public bool HasIsoFix { get; set; }
        public override Boot Boot { get ; set; }
        public override byte Amount_Of_Seats { get ; set ; }
        public override bool TowHook { get ; set ; }

        public override char Calculate_Engergy_Class()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
