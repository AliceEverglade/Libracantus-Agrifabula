using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    internal class Field
    {
        private Plant[,] field;

        public void SetField(int y, int x)
        {
            field = new Plant[y, x];
        }
    }
}
