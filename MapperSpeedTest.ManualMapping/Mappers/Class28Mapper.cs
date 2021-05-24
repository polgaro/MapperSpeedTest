using System;
using MapperSpeedTest.ManualMapping;

public class Class28Mapper : IMapper<ExampleSourceClass28, ExampleDTOClass28>
{
	public ExampleDTOClass28 Convert(ExampleSourceClass28 source)
    {
        return new ExampleDTOClass28
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
