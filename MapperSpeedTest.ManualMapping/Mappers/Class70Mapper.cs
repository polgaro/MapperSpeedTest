using System;
using MapperSpeedTest.ManualMapping;

public class Class70Mapper : IMapper<ExampleSourceClass70, ExampleDTOClass70>
{
	public ExampleDTOClass70 Convert(ExampleSourceClass70 source)
    {
        return new ExampleDTOClass70
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
