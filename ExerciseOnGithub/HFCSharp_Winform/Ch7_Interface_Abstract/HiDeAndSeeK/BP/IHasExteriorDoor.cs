using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    interface IHasExteriorDoor
    {
         string DoorDescription { get; }
         Location DoorLocation { get; set; }
    }
}
