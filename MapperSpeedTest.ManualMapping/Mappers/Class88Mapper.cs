using System;
using MapperSpeedTest.ManualMapping;

public class Class88Mapper : IMapper<ExampleSourceClass88, ExampleDTOClass88>
{
	public ExampleDTOClass88 Convert(ExampleSourceClass88 source)
    {
        return new ExampleDTOClass88
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
