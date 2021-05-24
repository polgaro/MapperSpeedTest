using System;
using MapperSpeedTest.ManualMapping;

public class Class65Mapper : IMapper<ExampleSourceClass65, ExampleDTOClass65>
{
	public ExampleDTOClass65 Convert(ExampleSourceClass65 source)
    {
        return new ExampleDTOClass65
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
