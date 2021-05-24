using System;
using MapperSpeedTest.ManualMapping;

public class Class34Mapper : IMapper<ExampleSourceClass34, ExampleDTOClass34>
{
	public ExampleDTOClass34 Convert(ExampleSourceClass34 source)
    {
        return new ExampleDTOClass34
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
