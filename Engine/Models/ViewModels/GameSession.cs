using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Models.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Lillie";
            CurrentPlayer.Gold = 1000000;
        }
    }
}
