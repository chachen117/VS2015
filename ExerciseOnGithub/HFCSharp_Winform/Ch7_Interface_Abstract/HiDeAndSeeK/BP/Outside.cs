﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    class Outside :Location
    {

        private bool hot;
        public bool Hot { get { return hot; } }

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += "It's very hot.";

                return NewDescription;
            }
        }
    }
}
