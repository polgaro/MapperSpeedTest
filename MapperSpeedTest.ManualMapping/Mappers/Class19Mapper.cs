using System;
using MapperSpeedTest.ManualMapping;

public class Class19Mapper : IMapper<ExampleSourceClass19, ExampleDTOClass19>
{
	public ExampleDTOClass19 Convert(ExampleSourceClass19 source)
    {
        return new ExampleDTOClass19
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
