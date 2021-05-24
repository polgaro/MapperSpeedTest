using System;
using MapperSpeedTest.ManualMapping;

public class Class91Mapper : IMapper<ExampleSourceClass91, ExampleDTOClass91>
{
	public ExampleDTOClass91 Convert(ExampleSourceClass91 source)
    {
        return new ExampleDTOClass91
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
