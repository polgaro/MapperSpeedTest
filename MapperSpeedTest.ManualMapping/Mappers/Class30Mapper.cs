using System;
using MapperSpeedTest.ManualMapping;

public class Class30Mapper : IMapper<ExampleSourceClass30, ExampleDTOClass30>
{
	public ExampleDTOClass30 Convert(ExampleSourceClass30 source)
    {
        return new ExampleDTOClass30
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
