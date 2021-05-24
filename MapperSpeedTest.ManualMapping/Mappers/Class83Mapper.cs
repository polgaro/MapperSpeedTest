using System;
using MapperSpeedTest.ManualMapping;

public class Class83Mapper : IMapper<ExampleSourceClass83, ExampleDTOClass83>
{
	public ExampleDTOClass83 Convert(ExampleSourceClass83 source)
    {
        return new ExampleDTOClass83
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
