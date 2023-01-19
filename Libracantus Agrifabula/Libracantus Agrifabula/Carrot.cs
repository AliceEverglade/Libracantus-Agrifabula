using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;

namespace Libracantus_Agrifabula
{
    class Carrot : Plant
    {
        public Carrot(string _name, float _stage2, float _stage3) : base(_name, _stage2, _stage3)
        {
            
        }

        public override string[,] GetTexture(int TextureIndex)
        {
            switch (TextureIndex)
            {
                case 1:
                    return Textures.seedlingTexture;
                case 2:
                    return Textures.plantTexture;
                case 3:
                    return Textures.carrotTexture;
                default:
                    return Textures.missingTexture;

            }
        }
    }
}
