using System;
using MapperSpeedTest.ManualMapping;

public class Class75Mapper : IMapper<ExampleSourceClass75, ExampleDTOClass75>
{
	public ExampleDTOClass75 Convert(ExampleSourceClass75 source)
    {
        return new ExampleDTOClass75
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
