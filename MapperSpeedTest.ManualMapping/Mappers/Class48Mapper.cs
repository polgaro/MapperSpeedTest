using System;
using MapperSpeedTest.ManualMapping;

public class Class48Mapper : IMapper<ExampleSourceClass48, ExampleDTOClass48>
{
	public ExampleDTOClass48 Convert(ExampleSourceClass48 source)
    {
        return new ExampleDTOClass48
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
