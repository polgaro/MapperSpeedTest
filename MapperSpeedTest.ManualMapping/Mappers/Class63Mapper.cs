using System;
using MapperSpeedTest.ManualMapping;

public class Class63Mapper : IMapper<ExampleSourceClass63, ExampleDTOClass63>
{
	public ExampleDTOClass63 Convert(ExampleSourceClass63 source)
    {
        return new ExampleDTOClass63
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
