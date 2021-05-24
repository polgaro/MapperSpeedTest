using System;
using MapperSpeedTest.ManualMapping;

public class Class85Mapper : IMapper<ExampleSourceClass85, ExampleDTOClass85>
{
	public ExampleDTOClass85 Convert(ExampleSourceClass85 source)
    {
        return new ExampleDTOClass85
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
