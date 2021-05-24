using System;
using MapperSpeedTest.ManualMapping;

public class Class90Mapper : IMapper<ExampleSourceClass90, ExampleDTOClass90>
{
	public ExampleDTOClass90 Convert(ExampleSourceClass90 source)
    {
        return new ExampleDTOClass90
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
