using System;
using MapperSpeedTest.ManualMapping;

public class Class49Mapper : IMapper<ExampleSourceClass49, ExampleDTOClass49>
{
	public ExampleDTOClass49 Convert(ExampleSourceClass49 source)
    {
        return new ExampleDTOClass49
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
