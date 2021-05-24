using System;
using MapperSpeedTest.ManualMapping;

public class Class06Mapper : IMapper<ExampleSourceClass06, ExampleDTOClass06>
{
	public ExampleDTOClass06 Convert(ExampleSourceClass06 source)
    {
        return new ExampleDTOClass06
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
