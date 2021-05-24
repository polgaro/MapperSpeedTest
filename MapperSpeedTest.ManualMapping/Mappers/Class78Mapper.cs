using System;
using MapperSpeedTest.ManualMapping;

public class Class78Mapper : IMapper<ExampleSourceClass78, ExampleDTOClass78>
{
	public ExampleDTOClass78 Convert(ExampleSourceClass78 source)
    {
        return new ExampleDTOClass78
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
