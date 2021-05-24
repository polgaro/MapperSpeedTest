using System;
using MapperSpeedTest.ManualMapping;

public class Class23Mapper : IMapper<ExampleSourceClass23, ExampleDTOClass23>
{
	public ExampleDTOClass23 Convert(ExampleSourceClass23 source)
    {
        return new ExampleDTOClass23
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
