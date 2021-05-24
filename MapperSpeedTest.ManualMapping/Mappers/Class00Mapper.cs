using System;
using MapperSpeedTest.ManualMapping;

public class Class00Mapper : IMapper<ExampleSourceClass00, ExampleDTOClass00>
{
	public ExampleDTOClass00 Convert(ExampleSourceClass00 source)
    {
        return new ExampleDTOClass00
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
