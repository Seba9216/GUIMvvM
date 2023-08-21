using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMvvM.Models.Veichles.Base_Classes
{
    public abstract class Base_Car : Veichle
    {
        public abstract Boot Boot { get; set; }
        public abstract byte Amount_Of_Seats { get; set; }





    }
}
