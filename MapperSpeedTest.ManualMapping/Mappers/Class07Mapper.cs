using System;
using MapperSpeedTest.ManualMapping;

public class Class07Mapper : IMapper<ExampleSourceClass07, ExampleDTOClass07>
{
	public ExampleDTOClass07 Convert(ExampleSourceClass07 source)
    {
        return new ExampleDTOClass07
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
