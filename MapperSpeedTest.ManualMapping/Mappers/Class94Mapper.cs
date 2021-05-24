using System;
using MapperSpeedTest.ManualMapping;

public class Class94Mapper : IMapper<ExampleSourceClass94, ExampleDTOClass94>
{
	public ExampleDTOClass94 Convert(ExampleSourceClass94 source)
    {
        return new ExampleDTOClass94
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
