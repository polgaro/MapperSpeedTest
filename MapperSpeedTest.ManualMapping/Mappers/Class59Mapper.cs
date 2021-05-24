using System;
using MapperSpeedTest.ManualMapping;

public class Class59Mapper : IMapper<ExampleSourceClass59, ExampleDTOClass59>
{
	public ExampleDTOClass59 Convert(ExampleSourceClass59 source)
    {
        return new ExampleDTOClass59
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
