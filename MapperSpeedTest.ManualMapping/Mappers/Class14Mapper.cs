using System;
using MapperSpeedTest.ManualMapping;

public class Class14Mapper : IMapper<ExampleSourceClass14, ExampleDTOClass14>
{
	public ExampleDTOClass14 Convert(ExampleSourceClass14 source)
    {
        return new ExampleDTOClass14
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
