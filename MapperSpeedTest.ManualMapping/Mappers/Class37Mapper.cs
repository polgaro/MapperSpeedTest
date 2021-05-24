using System;
using MapperSpeedTest.ManualMapping;

public class Class37Mapper : IMapper<ExampleSourceClass37, ExampleDTOClass37>
{
	public ExampleDTOClass37 Convert(ExampleSourceClass37 source)
    {
        return new ExampleDTOClass37
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
