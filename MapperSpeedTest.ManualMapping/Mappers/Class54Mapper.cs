using System;
using MapperSpeedTest.ManualMapping;

public class Class54Mapper : IMapper<ExampleSourceClass54, ExampleDTOClass54>
{
	public ExampleDTOClass54 Convert(ExampleSourceClass54 source)
    {
        return new ExampleDTOClass54
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
