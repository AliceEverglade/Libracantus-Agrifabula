using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    class Textures
    {
        /*TEMPLATE
         public static string[,] Texture =
         {
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
         };
        */


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

        public static string[,] grassTexture =
        {
            {Color.Green,Color.Green,Color.Green,Color.DarkGreen,Color.Green,Color.Green,Color.Green,Color.DarkGreen },
            {Color.DarkGreen,Color.DarkGreen,Color.Green,Color.Green,Color.Green,Color.Green,Color.Green,Color.DarkGreen },
            {Color.Green,Color.Green,Color.Green,Color.Green,Color.DarkGreen,Color.DarkGreen,Color.Green,Color.Green },
            {Color.Green,Color.Green,Color.DarkGreen,Color.Green,Color.Green,Color.DarkGreen,Color.Green,Color.Green },
            {Color.Green,Color.Green,Color.Green,Color.Green,Color.Green,Color.Green,Color.Green,Color.Green },
            {Color.Green,Color.Green,Color.Green,Color.Green,Color.DarkGreen,Color.Green,Color.Green,Color.Green },
            {Color.DarkGreen,Color.DarkGreen,Color.Green,Color.Green,Color.Green,Color.Green,Color.DarkGreen,Color.Green },
            {Color.Green,Color.Green,Color.Green,Color.DarkGreen,Color.Green,Color.Green,Color.DarkGreen,Color.Green }
        };

        public static string[,] cursorTexture =
         {
              {Color.White ,Color.White ,Color.White ,Color.Empty ,Color.Empty ,Color.White ,Color.White ,Color.White },
              {Color.White ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.White },
              {Color.White ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.White },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.White ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.White },
              {Color.White ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.White },
              {Color.White ,Color.White ,Color.White ,Color.Empty ,Color.Empty ,Color.White ,Color.White ,Color.White },
         };

        public static string[,] soilTexture =
         {
              {Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown },
              {Color.DarkBrown ,Color.DarkBrown ,Color.Brown ,Color.Brown ,Color.DarkBrown ,Color.DarkBrown ,Color.Brown ,Color.Brown },
              {Color.Brown ,Color.Brown ,Color.DarkBrown ,Color.DarkBrown ,Color.Brown ,Color.Brown ,Color.DarkBrown ,Color.DarkBrown },
              {Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown },
              {Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown },
              {Color.Brown ,Color.DarkBrown ,Color.DarkBrown ,Color.Brown ,Color.Brown ,Color.DarkBrown ,Color.DarkBrown ,Color.Brown },
              {Color.DarkBrown ,Color.Brown ,Color.Brown ,Color.DarkBrown ,Color.DarkBrown ,Color.Brown ,Color.Brown ,Color.DarkBrown },
              {Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown ,Color.Brown },
         };

        public static string[,] seedlingTexture =
         {
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
         };

        public static string[,] plantTexture =
         {
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
         };

        public static string[,] carrotTexture =
         {
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
         };

        public static string[,] redTulipTexture =
         {
              {Color.Empty ,Color.Empty ,Color.Red ,Color.Empty ,Color.Red ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Red ,Color.Red ,Color.Red ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Red ,Color.Red ,Color.Red ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Green ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Green ,Color.DarkGreen ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.DarkGreen ,Color.Green ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Green ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
              {Color.Empty ,Color.Empty ,Color.Empty ,Color.Green ,Color.Empty ,Color.Empty ,Color.Empty ,Color.Empty },
         };
    }
}
