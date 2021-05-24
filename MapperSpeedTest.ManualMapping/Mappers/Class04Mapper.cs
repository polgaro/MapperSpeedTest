using System;
using MapperSpeedTest.ManualMapping;

public class Class04Mapper : IMapper<ExampleSourceClass04, ExampleDTOClass04>
{
	public ExampleDTOClass04 Convert(ExampleSourceClass04 source)
    {
        return new ExampleDTOClass04
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
