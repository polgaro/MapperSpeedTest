using System;
using MapperSpeedTest.ManualMapping;

public class Class05Mapper : IMapper<ExampleSourceClass05, ExampleDTOClass05>
{
	public ExampleDTOClass05 Convert(ExampleSourceClass05 source)
    {
        return new ExampleDTOClass05
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
