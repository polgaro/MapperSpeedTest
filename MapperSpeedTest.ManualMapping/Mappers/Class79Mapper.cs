using System;
using MapperSpeedTest.ManualMapping;

public class Class79Mapper : IMapper<ExampleSourceClass79, ExampleDTOClass79>
{
	public ExampleDTOClass79 Convert(ExampleSourceClass79 source)
    {
        return new ExampleDTOClass79
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
