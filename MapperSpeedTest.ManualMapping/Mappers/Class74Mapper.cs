using System;
using MapperSpeedTest.ManualMapping;

public class Class74Mapper : IMapper<ExampleSourceClass74, ExampleDTOClass74>
{
	public ExampleDTOClass74 Convert(ExampleSourceClass74 source)
    {
        return new ExampleDTOClass74
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
