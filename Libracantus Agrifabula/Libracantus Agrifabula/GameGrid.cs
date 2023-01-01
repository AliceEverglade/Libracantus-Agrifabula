using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    internal class GameGrid
    {
        
        public string[,] GameWindow;
        private int SetGameGridWidth()
        {
            int width = Console.WindowWidth;
            while((width / 2) % constants.gridSize != 0)
            {
                width--;
            }
            return width;
            
        }
        private int SetGameGridHeight()
        {
            int height = Console.WindowHeight;
            while (height % constants.gridSize != 0)
            {
                height--;
            }
            return height;

        }

        public void SetGameWindow()
        {
            GameWindow = new string[SetGameGridWidth(), SetGameGridHeight()];
        }

        public string[,] GetGameWindow()
        {
            return GameWindow;
        }
    }
}
