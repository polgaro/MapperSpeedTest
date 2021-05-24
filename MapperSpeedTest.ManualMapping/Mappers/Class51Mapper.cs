using System;
using MapperSpeedTest.ManualMapping;

public class Class51Mapper : IMapper<ExampleSourceClass51, ExampleDTOClass51>
{
	public ExampleDTOClass51 Convert(ExampleSourceClass51 source)
    {
        return new ExampleDTOClass51
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
