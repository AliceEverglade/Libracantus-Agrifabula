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

        private static GameGrid FrameBufferGrid;
        private static List<GameGrid> LayerList = new List<GameGrid>();
        static void Main(string[] args)
        {
            #region Full Screen Code
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            #endregion
            
            Setup();
            LayerList[0].SetLayerName("Background");
            LayerList[1].SetLayerName("Plants");
            LayerList[2].SetLayerName("GUI");

            //TEST CODE
            LayerList[0].SetBackground();
            LayerList[1].SetCell(3, 4, Textures.redTulipTexture);
            LayerList[2].SetUI(3, 4);
            GridUpdate();
            PrintFrame();
            //end of test code
        }

        private static void Setup()
        {
            // create frame buffer and layers 
            FrameBufferGrid = new GameGrid();
            FrameBufferGrid.SetGameWindow();
            for (int i = 0; i < constants.LayerCount; i++)
            {
                GameGrid frame = new GameGrid();
                frame.SetGameWindow();
                LayerList.Add(frame);
            }
        }

        private static void GridUpdate()
        {
            for (int i = 0; i < constants.LayerCount; i++)
            {
                //for loop for row
                for (int j = 0; j < LayerList[i].GetGridHeight(); j++)
                {
                    //for loop for cell
                    for (int k = 0; k < LayerList[i].GetGridWidth(); k++)
                    {
                        //check if empty
                        if (    LayerList[i].GetGameWindow()[k, j] != "  " 
                            &&  LayerList[i].GetGameWindow()[k, j] != null 
                            &&  LayerList[i].GetGameWindow()[k, j] != "")
                        {
                            //put layer grid index into frame grid
                            FrameBufferGrid.GetGameWindow()[k, j] = LayerList[i].GetGameWindow()[k, j];
                        }
                    }
                }
            }
        }

        private static void PrintFrame()
        {
            //clear screen

            //for loop for col
            for (int i = 0; i < FrameBufferGrid.GetGridHeight(); i++)
            {
                //reset the line string
                string renderline = "";
                //for loop for row
                for (int j = 0; j < FrameBufferGrid.GetGridWidth(); j++)
                {
                    //put all cells in the row in 1 string
                    renderline += FrameBufferGrid.GetGameWindow()[j, i];
                }
                //print the entire row
                AnsiConsole.MarkupLine(renderline);
            }
        }
    }
}
