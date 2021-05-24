using System;
using MapperSpeedTest.ManualMapping;

public class Class33Mapper : IMapper<ExampleSourceClass33, ExampleDTOClass33>
{
	public ExampleDTOClass33 Convert(ExampleSourceClass33 source)
    {
        return new ExampleDTOClass33
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
