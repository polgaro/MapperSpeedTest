using System;
using MapperSpeedTest.ManualMapping;

public class Class97Mapper : IMapper<ExampleSourceClass97, ExampleDTOClass97>
{
	public ExampleDTOClass97 Convert(ExampleSourceClass97 source)
    {
        return new ExampleDTOClass97
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
