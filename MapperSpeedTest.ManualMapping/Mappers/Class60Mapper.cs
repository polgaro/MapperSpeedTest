using System;
using MapperSpeedTest.ManualMapping;

public class Class60Mapper : IMapper<ExampleSourceClass60, ExampleDTOClass60>
{
	public ExampleDTOClass60 Convert(ExampleSourceClass60 source)
    {
        return new ExampleDTOClass60
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
