using System;
using MapperSpeedTest.ManualMapping;

public class Class64Mapper : IMapper<ExampleSourceClass64, ExampleDTOClass64>
{
	public ExampleDTOClass64 Convert(ExampleSourceClass64 source)
    {
        return new ExampleDTOClass64
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
