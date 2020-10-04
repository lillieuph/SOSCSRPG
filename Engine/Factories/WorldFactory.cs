using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, -1, "Farmer's House", "This is the house of your neighbor, Farmer Ted.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/Farmhouse.png");
            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan, the trader.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town Square", "You see a fountain here.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "You feel your sins crawl on your back as you enter.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's Hut", "You see a small hut, with plants drying on the roof.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herbalist's Garden", "There are all sorts and sizes of plant growing here.", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(0, -1, "Home", "This is your home", "D:/Desktop/Coding Projects/SOSCSRPG/Engine/Images/Locations/Home.png");
            return newWorld;
        }
    }
}
