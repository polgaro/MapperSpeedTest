using System;
using MapperSpeedTest.ManualMapping;

public class Class87Mapper : IMapper<ExampleSourceClass87, ExampleDTOClass87>
{
	public ExampleDTOClass87 Convert(ExampleSourceClass87 source)
    {
        return new ExampleDTOClass87
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
