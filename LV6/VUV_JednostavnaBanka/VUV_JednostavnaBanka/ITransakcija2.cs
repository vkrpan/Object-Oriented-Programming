using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    interface ITransakcija2<T> : ITransakcije
    {
        void Usporedi(T nesta);

    }
}
