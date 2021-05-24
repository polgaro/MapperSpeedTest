using System;
using MapperSpeedTest.ManualMapping;

public class Class45Mapper : IMapper<ExampleSourceClass45, ExampleDTOClass45>
{
	public ExampleDTOClass45 Convert(ExampleSourceClass45 source)
    {
        return new ExampleDTOClass45
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
