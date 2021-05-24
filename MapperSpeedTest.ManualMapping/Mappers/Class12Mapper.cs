using System;
using MapperSpeedTest.ManualMapping;

public class Class12Mapper : IMapper<ExampleSourceClass12, ExampleDTOClass12>
{
	public ExampleDTOClass12 Convert(ExampleSourceClass12 source)
    {
        return new ExampleDTOClass12
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
