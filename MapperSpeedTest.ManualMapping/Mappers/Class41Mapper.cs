using System;
using MapperSpeedTest.ManualMapping;

public class Class41Mapper : IMapper<ExampleSourceClass41, ExampleDTOClass41>
{
	public ExampleDTOClass41 Convert(ExampleSourceClass41 source)
    {
        return new ExampleDTOClass41
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
