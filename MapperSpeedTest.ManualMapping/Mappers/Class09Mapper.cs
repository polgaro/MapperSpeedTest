using System;
using MapperSpeedTest.ManualMapping;

public class Class09Mapper : IMapper<ExampleSourceClass09, ExampleDTOClass09>
{
	public ExampleDTOClass09 Convert(ExampleSourceClass09 source)
    {
        return new ExampleDTOClass09
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
