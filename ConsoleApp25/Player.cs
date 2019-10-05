using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Player
    {
        public Vector2 vector = new Vector2();
        public ViewPlayer viewPlayer = new ViewPlayer();

        public Player(ConsoleColor consoleColorPlayer, char spritePlayer, int startpositonX, int startposironY)
        {
            viewPlayer.spritePlayer = spritePlayer;
            viewPlayer.consoleColorPlayer = consoleColorPlayer;

            vector.x = startpositonX;
            vector.y = startposironY;

         
        }


    }
}
