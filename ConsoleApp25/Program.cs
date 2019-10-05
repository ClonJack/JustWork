using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(ConsoleColor.Yellow,'@',2,2);
        
            ControllPlayer playerControl = new ControllPlayer(player);

           
            playerControl.MovenetPlayer();
          
           
           
        }
    }
}
