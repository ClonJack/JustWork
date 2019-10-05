using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class ControllPlayer
    {
        public Player Player { get; set; }

        public ControllPlayer(Player player) => Player = player;

       
        
     
        private void StartPositon()
        {
            Console.SetCursorPosition(Player.vector.x, Player.vector.y);
            Console.Write(Player.viewPlayer.spritePlayer);

        }

        private void ClearLastTrace()
        {
            Console.SetCursorPosition(Player.vector.x, Player.vector.y);
            Console.Write(" ");
            
        }

        public void MovenetPlayer()
        {

            Console.CursorVisible = false;

            StartPositon();


            while (true)
            {
                DrawPlayer();


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        ClearLastTrace();
                        Player.vector.x--;
                        break;

                    case ConsoleKey.RightArrow:
                        ClearLastTrace();
                        Player.vector.x++;
                        break;

                    case ConsoleKey.UpArrow:
                        ClearLastTrace();
                        Player.vector.y--;
                        break;

                    case ConsoleKey.DownArrow:
                        ClearLastTrace();
                        Player.vector.y++;
                        break;
                }

            }

        }

        private void DrawPlayer()
        {
            Console.ForegroundColor = Player.viewPlayer.consoleColorPlayer;
            Console.SetCursorPosition(Player.vector.x, Player.vector.y);
            Console.Write(Player.viewPlayer.spritePlayer);

            



        }
    }
}
