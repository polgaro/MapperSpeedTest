using System;
using MapperSpeedTest.ManualMapping;

public class Class35Mapper : IMapper<ExampleSourceClass35, ExampleDTOClass35>
{
	public ExampleDTOClass35 Convert(ExampleSourceClass35 source)
    {
        return new ExampleDTOClass35
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
