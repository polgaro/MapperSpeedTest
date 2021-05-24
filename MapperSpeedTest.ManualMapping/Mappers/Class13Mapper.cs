using System;
using MapperSpeedTest.ManualMapping;

public class Class13Mapper : IMapper<ExampleSourceClass13, ExampleDTOClass13>
{
	public ExampleDTOClass13 Convert(ExampleSourceClass13 source)
    {
        return new ExampleDTOClass13
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
