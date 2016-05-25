using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Ch7_Interface_Abstract
{
    class ScaryClown : FunnyClown, IScaryClown
    {
        public ScaryClown(string funnyThingIHave, int numberOfScaryThings)
            :base (funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThings + " spiders ";
            }
        }

        public void ScareLittleChildren()
        {            
            Console.WriteLine ( "Boo! Gotcha!" );
        }
    }
}
