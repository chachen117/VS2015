using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Ch7_Interface_Abstract
{
    class FunnyClown : IClown
    {

        public  FunnyClown(string FunnyThingIHave)
        {
            this.funnyThingIHave = FunnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return "Honk honk! I have " + this.funnyThingIHave;
            }
        }

        public void  Honk()
        {
            Console.WriteLine( FunnyThingIHave);
        }
    }
}
