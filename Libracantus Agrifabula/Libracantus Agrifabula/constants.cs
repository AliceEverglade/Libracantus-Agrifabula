using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    //██
    class constants
    {
        public const int gridSize = 8;
        public const int LayerCount = 3;
        public const int MarginRight = 1;
        public static string[,] missingTexture =
        {
            {Color.Pink,Color.Pink,Color.Pink,Color.Pink,Color.Black,Color.Black,Color.Black,Color.Black },
            {Color.Pink,Color.Pink,Color.Pink,Color.Pink,Color.Black,Color.Black,Color.Black,Color.Black },
            {Color.Pink,Color.Pink,Color.Pink,Color.Pink,Color.Black,Color.Black,Color.Black,Color.Black },
            {Color.Pink,Color.Pink,Color.Pink,Color.Pink,Color.Black,Color.Black,Color.Black,Color.Black },
            {Color.Black,Color.Black,Color.Black,Color.Black,Color.Pink,Color.Pink,Color.Pink,Color.Pink },
            {Color.Black,Color.Black,Color.Black,Color.Black,Color.Pink,Color.Pink,Color.Pink,Color.Pink },
            {Color.Black,Color.Black,Color.Black,Color.Black,Color.Pink,Color.Pink,Color.Pink,Color.Pink },
            {Color.Black,Color.Black,Color.Black,Color.Black,Color.Pink,Color.Pink,Color.Pink,Color.Pink }
        };
    }
}
