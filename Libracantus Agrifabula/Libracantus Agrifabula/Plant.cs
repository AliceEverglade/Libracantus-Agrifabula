using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    abstract class Plant
    {
        private string name;
        private int renderLayer = 2;
        private float growthStageCounter;
        private float growthStageThreshold2;
        private float growthStageThreshold3;

        public Plant(string _name, float _stage2, float _stage3)
        {
            this.name = _name;
            this.growthStageThreshold2 = _stage2;
            this.growthStageThreshold3 = _stage3;
        }

        public float GetStageThreshold(int index)
        {
            switch (index)
            {
                case 2:
                    return growthStageThreshold2;
                case 3:
                    return growthStageThreshold3;
                default:
                    return 0;
            }
        }

        public int GetRenderLayer()
        {
            return renderLayer;
        }

        public abstract string[,] GetTexture(int TextureIndex);

        public string[,] GetCurrentTexture(float counter)
        {
            if (counter < this.GetStageThreshold(2))
            {
                //texture 1
                return GetTexture(1);
            }
            else if (counter < this.GetStageThreshold(3))
            {
                //texture 2
                return GetTexture(2);
            }
            else
            {
                //texture 3
                return GetTexture(3);
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}
