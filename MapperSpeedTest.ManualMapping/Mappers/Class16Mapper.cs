using System;
using MapperSpeedTest.ManualMapping;

public class Class16Mapper : IMapper<ExampleSourceClass16, ExampleDTOClass16>
{
	public ExampleDTOClass16 Convert(ExampleSourceClass16 source)
    {
        return new ExampleDTOClass16
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
