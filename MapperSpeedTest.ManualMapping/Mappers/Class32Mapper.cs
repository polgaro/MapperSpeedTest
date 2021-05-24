using System;
using MapperSpeedTest.ManualMapping;

public class Class32Mapper : IMapper<ExampleSourceClass32, ExampleDTOClass32>
{
	public ExampleDTOClass32 Convert(ExampleSourceClass32 source)
    {
        return new ExampleDTOClass32
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
