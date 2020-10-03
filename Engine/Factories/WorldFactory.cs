using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, -1, "Home", "This is your home", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/Home.png");
            return newWorld;
        }
    }
}
