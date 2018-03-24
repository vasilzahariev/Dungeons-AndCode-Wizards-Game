using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame
{
    public class Engine
    {
        public static HomeForm Home;
        public static GameForm Game;
        public static bool IsGameOver = false;

        public static HomeForm CreateHome()
        {
            Home = new HomeForm();

            return Home;
        }

        public static void CreateGame()
        {
            Checker.WasGamePlayed();

            Game = new GameForm();
        }
    }
}
