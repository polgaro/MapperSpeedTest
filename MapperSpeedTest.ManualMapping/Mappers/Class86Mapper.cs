using System;
using MapperSpeedTest.ManualMapping;

public class Class86Mapper : IMapper<ExampleSourceClass86, ExampleDTOClass86>
{
	public ExampleDTOClass86 Convert(ExampleSourceClass86 source)
    {
        return new ExampleDTOClass86
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
