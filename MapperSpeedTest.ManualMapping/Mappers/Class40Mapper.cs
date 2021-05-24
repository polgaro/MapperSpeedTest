using System;
using MapperSpeedTest.ManualMapping;

public class Class40Mapper : IMapper<ExampleSourceClass40, ExampleDTOClass40>
{
	public ExampleDTOClass40 Convert(ExampleSourceClass40 source)
    {
        return new ExampleDTOClass40
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
