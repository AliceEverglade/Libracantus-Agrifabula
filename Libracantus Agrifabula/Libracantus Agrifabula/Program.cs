using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Spectre.Console;

namespace Libracantus_Agrifabula
{
    class Program
    {
        #region Full Screen Vars
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        #endregion

        private GameGrid FrameBufferGrid;
        private List<GameGrid> LayerList = new List<GameGrid>();
        static void Main(string[] args)
        {
            #region Full Screen Code
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            #endregion
            
            for (int i = 0; i < constants.gridSize; i++)
            {
                string line = "";
                for (int j = 0; j < constants.gridSize; j++)
                {
                    line += constants.missingTexture[j, i];
                }
                AnsiConsole.MarkupLine(line);
            }
            AnsiConsole.MarkupLine(Color.Black + Color.DarkGray + Color.Gray + Color.LightGray + Color.White);
        }
        
        private void Setup()
        {
            FrameBufferGrid = new GameGrid();
            for (int i = 0; i < constants.LayerCount; i++)
            {
                GameGrid frame = new GameGrid();
                LayerList.Add(frame);
            }
        }

        private void GridUpdate()
        {
            for (int i = 0; i < constants.LayerCount; i++)
            {
                //row for loop
                    //col for loop
                        //put layer grid index into frame grid
            }
        }

        private void PrintFrame()
        {

        }
    }
}
