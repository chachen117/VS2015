using HeadFirstCSharp.Ch7_Interface_Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFCSharp.Ch7_Interface_Abstract
{
    class testClown
    {
        static void Main(string[] args)
        {

            ScaryClown fingersTheClown = new ScaryClown("big shoes", 14);
            FunnyClown someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryClown;
            someOtherScaryClown.Honk();
            Console.ReadLine();

        }
    }
}
