using System;
using MapperSpeedTest.ManualMapping;

public class Class24Mapper : IMapper<ExampleSourceClass24, ExampleDTOClass24>
{
	public ExampleDTOClass24 Convert(ExampleSourceClass24 source)
    {
        return new ExampleDTOClass24
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
