using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    class Room : Location
    {

        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        private string decoration;
        public string Decoration
        {
            get {return this.decoration; }
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
