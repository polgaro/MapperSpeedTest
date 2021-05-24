using System;
using MapperSpeedTest.ManualMapping;

public class Class44Mapper : IMapper<ExampleSourceClass44, ExampleDTOClass44>
{
	public ExampleDTOClass44 Convert(ExampleSourceClass44 source)
    {
        return new ExampleDTOClass44
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
