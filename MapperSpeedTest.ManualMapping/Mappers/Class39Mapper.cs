using System;
using MapperSpeedTest.ManualMapping;

public class Class39Mapper : IMapper<ExampleSourceClass39, ExampleDTOClass39>
{
	public ExampleDTOClass39 Convert(ExampleSourceClass39 source)
    {
        return new ExampleDTOClass39
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
