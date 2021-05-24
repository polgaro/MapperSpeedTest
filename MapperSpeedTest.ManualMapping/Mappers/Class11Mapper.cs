using System;
using MapperSpeedTest.ManualMapping;

public class Class11Mapper : IMapper<ExampleSourceClass11, ExampleDTOClass11>
{
	public ExampleDTOClass11 Convert(ExampleSourceClass11 source)
    {
        return new ExampleDTOClass11
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
