using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Ch7_Interface_Abstract
{
    class Implement_INectarCollerctor : INectarCollector
    {
        public void FindFlowers()
        {
            Console.WriteLine("FindFlowers");
        } 

        public void GatherNectar()
        {
            Console.WriteLine("GatherNectar");
        }

        public void ReturnToHive()
        {
            Console.WriteLine("ReturnToHive");
        }
    }
}
