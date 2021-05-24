using System;
using MapperSpeedTest.ManualMapping;

public class Class92Mapper : IMapper<ExampleSourceClass92, ExampleDTOClass92>
{
	public ExampleDTOClass92 Convert(ExampleSourceClass92 source)
    {
        return new ExampleDTOClass92
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
