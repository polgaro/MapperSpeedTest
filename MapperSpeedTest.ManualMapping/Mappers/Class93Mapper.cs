using System;
using MapperSpeedTest.ManualMapping;

public class Class93Mapper : IMapper<ExampleSourceClass93, ExampleDTOClass93>
{
	public ExampleDTOClass93 Convert(ExampleSourceClass93 source)
    {
        return new ExampleDTOClass93
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
