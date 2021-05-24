using System;
using MapperSpeedTest.ManualMapping;

public class Class72Mapper : IMapper<ExampleSourceClass72, ExampleDTOClass72>
{
	public ExampleDTOClass72 Convert(ExampleSourceClass72 source)
    {
        return new ExampleDTOClass72
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
