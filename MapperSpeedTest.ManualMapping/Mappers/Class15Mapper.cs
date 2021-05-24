using System;
using MapperSpeedTest.ManualMapping;

public class Class15Mapper : IMapper<ExampleSourceClass15, ExampleDTOClass15>
{
	public ExampleDTOClass15 Convert(ExampleSourceClass15 source)
    {
        return new ExampleDTOClass15
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
