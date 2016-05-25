﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSharp_Winform.Ch7_Interface_Abstract
{
    public abstract class Location
    {
        public Location(string name)
        {
            this.name = name;
        }

        public Location[] Exits;

        private string name;
        public string Name { get { return name; } }

        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + name
                    + ". You see exits to the following places:";

                for(int i = 0; i < Exits.Length; i ++)
                {
                    description += " " + Exits[i].name;
                }
                description += ".";
                    return description;
            }
        }
    }
}
