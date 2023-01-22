using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    internal class GameGrid
    {
        //██
        private string[,] GameWindow;
        private string layerName;
        private int GridHeight;
        private int GridWidth;
        private int CellsX;
        private int CellsY;
        private int SetGameGridWidth()
        {
            int width = Console.WindowWidth - Constants.MarginRight;
            
            while((Convert.ToSingle(width) / 2) % Constants.gridSize != 0)
            {
                width--;
            }
            GridWidth = width / 2;
            CellsX = GridWidth / Constants.gridSize;
            return width / 2;
            
        }
        private int SetGameGridHeight()
        {
            int height = Console.WindowHeight;
            while (height % Constants.gridSize != 0)
            {
                height--;
            }
            GridHeight = height;
            CellsY = GridHeight / Constants.gridSize;
            return height;

        }

        public void SetGameWindow()
        {
            GameWindow = new string[SetGameGridWidth(), SetGameGridHeight()];
        }

        public void SetLayerName(string name)
        {
            layerName = name;
        }

        public string GetLayerName()
        {
            return layerName;
        }

        public void PlaceTexture(int x, int y, string[,] texture)
        {
            for (int i = 0; i < Constants.gridSize; i++)
            {
                for (int j = 0; j < Constants.gridSize; j++)
                {
                    GameWindow[x + i, y + j] = texture[x, y];
                }
            }
        }

        public void ClearGrid()
        {
            Array.Clear(GameWindow,0,GameWindow.Length);
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

        public void SetCell(int x, int y, string[,] texture)
        {
            for (int i = 0; i < Constants.gridSize; i++)
            {
                for (int j = 0; j < Constants.gridSize; j++)
                {
                    GameWindow[y * Constants.gridSize + i, x * Constants.gridSize + j] = texture[j, i];
                }
            }
        }

        public void SetBackground()
        {
            if(layerName == "Background")
            {
                for (int i = 0; i < CellsY; i++)
                {
                    for (int j = 0; j < CellsX; j++)
                    {
                        if (i == 0 || j == 0 || i == CellsY - 1 || j == CellsX - 1)
                        {
                            SetCell(i, j, Textures.grassTexture);
                        }
                        else
                        {
                            SetCell(i, j, Textures.soilTexture);
                        }
                    }
                }
            }
        }

        public void SetUI(int x, int y)
        {
            if(layerName == "GUI")
            {
                /*
                for (int i = 0; i < GridHeight; i++)
                {
                    for (int j = 0; j < GridWidth; j++)
                    {

                        if (i == 0 || i == 1 || i == GridHeight - 1 || i == GridHeight - 2)
                        {
                            GameWindow[j, i] = Color.White;
                        }
                        else if (j == 0 || j == 1 || j == GridWidth - 1 || j == GridWidth - 2)
                        {
                            GameWindow[j, i] = Color.White;
                        }
                        else
                        {
                            GameWindow[j, i] = Color.Empty;
                        }
                    }
                }
                */
                SetCell(x, y, Textures.cursorTexture);
            }
            
        }

        
    }
}
