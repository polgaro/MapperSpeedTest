using System;
using MapperSpeedTest.ManualMapping;

public class Class08Mapper : IMapper<ExampleSourceClass08, ExampleDTOClass08>
{
	public ExampleDTOClass08 Convert(ExampleSourceClass08 source)
    {
        return new ExampleDTOClass08
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
