using System;
using System.Collections.Generic;
using System.Text;

namespace MapperSpeedTest.Entities
{
    public static class Class00Helper
    {
        public static ExampleSourceClass00 GenerateRandom()
        {
            var rnd = new Random();
            return new ExampleSourceClass00
            {
                Property1 = System.Guid.NewGuid().ToString(),
                Property2 = rnd.Next(0, 10000),

                //just to simplify, up to day 28th
                Property3 = new DateTime (rnd.Next(1900, 2050), rnd.Next(1, 12), rnd.Next(1, 28))
            };
        }
    }
}
