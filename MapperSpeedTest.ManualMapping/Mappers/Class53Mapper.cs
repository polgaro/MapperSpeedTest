using System;
using MapperSpeedTest.ManualMapping;

public class Class53Mapper : IMapper<ExampleSourceClass53, ExampleDTOClass53>
{
	public ExampleDTOClass53 Convert(ExampleSourceClass53 source)
    {
        return new ExampleDTOClass53
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
