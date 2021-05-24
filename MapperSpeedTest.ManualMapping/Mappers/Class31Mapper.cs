using System;
using MapperSpeedTest.ManualMapping;

public class Class31Mapper : IMapper<ExampleSourceClass31, ExampleDTOClass31>
{
	public ExampleDTOClass31 Convert(ExampleSourceClass31 source)
    {
        return new ExampleDTOClass31
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
