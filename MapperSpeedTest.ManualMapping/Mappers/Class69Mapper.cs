using System;
using MapperSpeedTest.ManualMapping;

public class Class69Mapper : IMapper<ExampleSourceClass69, ExampleDTOClass69>
{
	public ExampleDTOClass69 Convert(ExampleSourceClass69 source)
    {
        return new ExampleDTOClass69
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
