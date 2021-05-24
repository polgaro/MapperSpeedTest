using System;
using MapperSpeedTest.ManualMapping;

public class Class42Mapper : IMapper<ExampleSourceClass42, ExampleDTOClass42>
{
	public ExampleDTOClass42 Convert(ExampleSourceClass42 source)
    {
        return new ExampleDTOClass42
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
