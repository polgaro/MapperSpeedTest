using System;
using MapperSpeedTest.ManualMapping;

public class Class21Mapper : IMapper<ExampleSourceClass21, ExampleDTOClass21>
{
	public ExampleDTOClass21 Convert(ExampleSourceClass21 source)
    {
        return new ExampleDTOClass21
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
