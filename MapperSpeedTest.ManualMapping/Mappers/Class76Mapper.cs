using System;
using MapperSpeedTest.ManualMapping;

public class Class76Mapper : IMapper<ExampleSourceClass76, ExampleDTOClass76>
{
	public ExampleDTOClass76 Convert(ExampleSourceClass76 source)
    {
        return new ExampleDTOClass76
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
