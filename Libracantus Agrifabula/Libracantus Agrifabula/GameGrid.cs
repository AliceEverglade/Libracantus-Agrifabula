using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    internal class GameGrid
    {
        //██
        private string[,] GameWindow;
        private int GridHeight;
        private int GridWidth;
        private int SetGameGridWidth()
        {
            int width = Console.WindowWidth - constants.MarginRight;
            
            while((Convert.ToSingle(width) / 2) % constants.gridSize != 0)
            {
                width--;
            }
            GridWidth = width / 2;
            return width / 2;
            
        }
        private int SetGameGridHeight()
        {
            int height = Console.WindowHeight;
            while (height % constants.gridSize != 0)
            {
                height--;
            }
            GridHeight = height;
            return height;

        }

        public void SetGameWindow()
        {
            GameWindow = new string[SetGameGridWidth(), SetGameGridHeight()];
        }

        public void PlaceTexture(int x, int y, string[,] texture)
        {
            for (int i = 0; i < constants.gridSize; i++)
            {
                for (int j = 0; j < constants.gridSize; j++)
                {
                    GameWindow[x + i, y + j] = texture[x, y];
                }
            }
        }

        public string[,] GetGameWindow()
        {
            return GameWindow;
        }

        public int GetGridWidth()
        {
            return GridWidth;
        }

        public int GetGridHeight()
        {
            return GridHeight;
        }

        public void TESTRender()
        {
            for (int i = 0; i < GridHeight; i++)
            {
                for (int j = 0; j < GridWidth; j++)
                {
                    
                    if(i == 0 || i == GridHeight - 1)
                    {
                        GameWindow[j, i] = Color.White;
                    }
                    else if (j == 0 || j == GridWidth - 1)
                    {
                        GameWindow[j, i] = Color.Green;
                    }
                    else
                    {
                        GameWindow[j, i] = Color.DarkBlue;
                    }
                }
            }
        }

        
    }
}
