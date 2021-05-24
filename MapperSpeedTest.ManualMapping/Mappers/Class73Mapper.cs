using System;
using MapperSpeedTest.ManualMapping;

public class Class73Mapper : IMapper<ExampleSourceClass73, ExampleDTOClass73>
{
	public ExampleDTOClass73 Convert(ExampleSourceClass73 source)
    {
        return new ExampleDTOClass73
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
