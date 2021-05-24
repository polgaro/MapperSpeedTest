using System;
using MapperSpeedTest.ManualMapping;

public class Class96Mapper : IMapper<ExampleSourceClass96, ExampleDTOClass96>
{
	public ExampleDTOClass96 Convert(ExampleSourceClass96 source)
    {
        return new ExampleDTOClass96
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
