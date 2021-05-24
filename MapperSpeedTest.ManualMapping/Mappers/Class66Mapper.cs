using System;
using MapperSpeedTest.ManualMapping;

public class Class66Mapper : IMapper<ExampleSourceClass66, ExampleDTOClass66>
{
	public ExampleDTOClass66 Convert(ExampleSourceClass66 source)
    {
        return new ExampleDTOClass66
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
