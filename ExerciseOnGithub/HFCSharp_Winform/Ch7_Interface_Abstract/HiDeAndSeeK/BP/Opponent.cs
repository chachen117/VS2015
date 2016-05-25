using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    class Opponent
    {

        #region Declaration

        private Random random;
        private Location myLocation;

        #endregion

        #region Constructor

        public Opponent (Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        #endregion

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;

                if (random.Next(2) == 1)
                    myLocation = LocationWithDoor.DoorLocation;
            }
            bool hidden = false;
            while (!hidden)
            {
                int rand = random .Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];

                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }

        public bool Check(Location locationToCheck)
        {
            bool result = false;
            if (locationToCheck != myLocation)
                result = false;
            else
                result = true;

            return result;
        }




    }
}
