using System;
using MapperSpeedTest.ManualMapping;

public class Class95Mapper : IMapper<ExampleSourceClass95, ExampleDTOClass95>
{
	public ExampleDTOClass95 Convert(ExampleSourceClass95 source)
    {
        return new ExampleDTOClass95
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
