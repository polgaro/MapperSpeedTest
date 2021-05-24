using System;
using MapperSpeedTest.ManualMapping;

public class Class18Mapper : IMapper<ExampleSourceClass18, ExampleDTOClass18>
{
	public ExampleDTOClass18 Convert(ExampleSourceClass18 source)
    {
        return new ExampleDTOClass18
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
