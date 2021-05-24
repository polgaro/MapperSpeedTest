using System;
using MapperSpeedTest.ManualMapping;

public class Class26Mapper : IMapper<ExampleSourceClass26, ExampleDTOClass26>
{
	public ExampleDTOClass26 Convert(ExampleSourceClass26 source)
    {
        return new ExampleDTOClass26
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
