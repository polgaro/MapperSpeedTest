using System;
using MapperSpeedTest.ManualMapping;

public class Class62Mapper : IMapper<ExampleSourceClass62, ExampleDTOClass62>
{
	public ExampleDTOClass62 Convert(ExampleSourceClass62 source)
    {
        return new ExampleDTOClass62
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
