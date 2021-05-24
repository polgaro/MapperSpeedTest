using System;
using MapperSpeedTest.ManualMapping;

public class Class67Mapper : IMapper<ExampleSourceClass67, ExampleDTOClass67>
{
	public ExampleDTOClass67 Convert(ExampleSourceClass67 source)
    {
        return new ExampleDTOClass67
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
