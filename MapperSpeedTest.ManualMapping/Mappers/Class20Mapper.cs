using System;
using MapperSpeedTest.ManualMapping;

public class Class20Mapper : IMapper<ExampleSourceClass20, ExampleDTOClass20>
{
	public ExampleDTOClass20 Convert(ExampleSourceClass20 source)
    {
        return new ExampleDTOClass20
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
