using System;
using MapperSpeedTest.ManualMapping;

public class Class01Mapper : IMapper<ExampleSourceClass01, ExampleDTOClass01>
{
	public ExampleDTOClass01 Convert(ExampleSourceClass01 source)
    {
        return new ExampleDTOClass01
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
