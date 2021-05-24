using System;
using MapperSpeedTest.ManualMapping;

public class Class27Mapper : IMapper<ExampleSourceClass27, ExampleDTOClass27>
{
	public ExampleDTOClass27 Convert(ExampleSourceClass27 source)
    {
        return new ExampleDTOClass27
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
