using System;
using MapperSpeedTest.ManualMapping;

public class Class57Mapper : IMapper<ExampleSourceClass57, ExampleDTOClass57>
{
	public ExampleDTOClass57 Convert(ExampleSourceClass57 source)
    {
        return new ExampleDTOClass57
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
