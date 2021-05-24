using System;
using MapperSpeedTest.ManualMapping;

public class Class47Mapper : IMapper<ExampleSourceClass47, ExampleDTOClass47>
{
	public ExampleDTOClass47 Convert(ExampleSourceClass47 source)
    {
        return new ExampleDTOClass47
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
