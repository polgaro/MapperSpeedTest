using System;
using MapperSpeedTest.ManualMapping;

public class Class36Mapper : IMapper<ExampleSourceClass36, ExampleDTOClass36>
{
	public ExampleDTOClass36 Convert(ExampleSourceClass36 source)
    {
        return new ExampleDTOClass36
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
