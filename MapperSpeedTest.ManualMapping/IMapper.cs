using System;
using System.Collections.Generic;
using System.Text;

namespace MapperSpeedTest.ManualMapping
{
    public interface IMapper<TIn, TOut>
    {
        TOut Convert(TIn source);
    }
}
