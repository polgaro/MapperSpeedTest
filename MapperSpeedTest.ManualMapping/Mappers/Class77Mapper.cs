using System;
using MapperSpeedTest.ManualMapping;

public class Class77Mapper : IMapper<ExampleSourceClass77, ExampleDTOClass77>
{
	public ExampleDTOClass77 Convert(ExampleSourceClass77 source)
    {
        return new ExampleDTOClass77
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
