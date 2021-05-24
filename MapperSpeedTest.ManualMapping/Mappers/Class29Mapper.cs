using System;
using MapperSpeedTest.ManualMapping;

public class Class29Mapper : IMapper<ExampleSourceClass29, ExampleDTOClass29>
{
	public ExampleDTOClass29 Convert(ExampleSourceClass29 source)
    {
        return new ExampleDTOClass29
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
