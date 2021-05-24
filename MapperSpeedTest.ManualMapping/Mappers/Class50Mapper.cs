using System;
using MapperSpeedTest.ManualMapping;

public class Class50Mapper : IMapper<ExampleSourceClass50, ExampleDTOClass50>
{
	public ExampleDTOClass50 Convert(ExampleSourceClass50 source)
    {
        return new ExampleDTOClass50
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
