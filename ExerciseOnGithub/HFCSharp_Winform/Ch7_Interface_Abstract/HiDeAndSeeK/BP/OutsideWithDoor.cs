using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    class OutsideWithDoor:Outside, IHasExteriorDoor
    {
        #region "Constructor"

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        #endregion

        #region "Proerty"

        private string doorDescription;
        public string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }

        #endregion

        public override string Description
        {
            get
            {
                return base.Description + " You see " + doorDescription + ".";                
            }
        }
 
    }
}
