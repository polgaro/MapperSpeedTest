using System;
using MapperSpeedTest.ManualMapping;

public class Class84Mapper : IMapper<ExampleSourceClass84, ExampleDTOClass84>
{
	public ExampleDTOClass84 Convert(ExampleSourceClass84 source)
    {
        return new ExampleDTOClass84
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
