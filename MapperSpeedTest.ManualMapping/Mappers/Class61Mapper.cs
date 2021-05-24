using System;
using MapperSpeedTest.ManualMapping;

public class Class61Mapper : IMapper<ExampleSourceClass61, ExampleDTOClass61>
{
	public ExampleDTOClass61 Convert(ExampleSourceClass61 source)
    {
        return new ExampleDTOClass61
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
