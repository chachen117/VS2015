﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    class RoomWithHidingPlace :Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name , string decoration, string hidingPlaceName)
            :base(name, decoration)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get { return hidingPlaceName; }
        }

        public override string Description
        {
            get
            {
                return base.Description + " Some could hide " + hidingPlaceName + ".";
            }
        }
    }
}
