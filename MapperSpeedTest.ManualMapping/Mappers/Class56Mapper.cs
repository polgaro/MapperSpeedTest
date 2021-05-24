using System;
using MapperSpeedTest.ManualMapping;

public class Class56Mapper : IMapper<ExampleSourceClass56, ExampleDTOClass56>
{
	public ExampleDTOClass56 Convert(ExampleSourceClass56 source)
    {
        return new ExampleDTOClass56
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
