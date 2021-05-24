using System;
using MapperSpeedTest.ManualMapping;

public class Class55Mapper : IMapper<ExampleSourceClass55, ExampleDTOClass55>
{
	public ExampleDTOClass55 Convert(ExampleSourceClass55 source)
    {
        return new ExampleDTOClass55
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
