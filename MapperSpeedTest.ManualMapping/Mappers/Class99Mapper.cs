using System;
using MapperSpeedTest.ManualMapping;

public class Class99Mapper : IMapper<ExampleSourceClass99, ExampleDTOClass99>
{
	public ExampleDTOClass99 Convert(ExampleSourceClass99 source)
    {
        return new ExampleDTOClass99
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
