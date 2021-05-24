using System;
using MapperSpeedTest.ManualMapping;

public class Class25Mapper : IMapper<ExampleSourceClass25, ExampleDTOClass25>
{
	public ExampleDTOClass25 Convert(ExampleSourceClass25 source)
    {
        return new ExampleDTOClass25
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
