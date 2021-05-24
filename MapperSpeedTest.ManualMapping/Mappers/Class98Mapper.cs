using System;
using MapperSpeedTest.ManualMapping;

public class Class98Mapper : IMapper<ExampleSourceClass98, ExampleDTOClass98>
{
	public ExampleDTOClass98 Convert(ExampleSourceClass98 source)
    {
        return new ExampleDTOClass98
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
