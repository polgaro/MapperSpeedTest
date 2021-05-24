using System;
using MapperSpeedTest.ManualMapping;

public class Class68Mapper : IMapper<ExampleSourceClass68, ExampleDTOClass68>
{
	public ExampleDTOClass68 Convert(ExampleSourceClass68 source)
    {
        return new ExampleDTOClass68
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
