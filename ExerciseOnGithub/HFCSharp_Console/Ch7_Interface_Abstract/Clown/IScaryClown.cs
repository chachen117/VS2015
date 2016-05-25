using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Ch7_Interface_Abstract
{
    interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
