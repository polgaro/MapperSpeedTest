using System;
using System.Collections.Generic;

namespace MapperSpeedTest.Common
{
    public static class CommonHelper
    {
        public static void ValidateTransformation(ExampleSourceClass00 source, ExampleDTOClass00 response)
        {
            if (response.Property1 != source.Property1)
            {
                throw new Exception("Problem in mapping");
            }
        }
    }
}
