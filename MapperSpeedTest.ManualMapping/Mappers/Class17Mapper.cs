using System;
using MapperSpeedTest.ManualMapping;

public class Class17Mapper : IMapper<ExampleSourceClass17, ExampleDTOClass17>
{
	public ExampleDTOClass17 Convert(ExampleSourceClass17 source)
    {
        return new ExampleDTOClass17
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
