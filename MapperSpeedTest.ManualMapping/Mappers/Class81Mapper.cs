using System;
using MapperSpeedTest.ManualMapping;

public class Class81Mapper : IMapper<ExampleSourceClass81, ExampleDTOClass81>
{
	public ExampleDTOClass81 Convert(ExampleSourceClass81 source)
    {
        return new ExampleDTOClass81
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
