using System;
using MapperSpeedTest.ManualMapping;

public class Class46Mapper : IMapper<ExampleSourceClass46, ExampleDTOClass46>
{
	public ExampleDTOClass46 Convert(ExampleSourceClass46 source)
    {
        return new ExampleDTOClass46
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
