using System;
using MapperSpeedTest.ManualMapping;

public class Class43Mapper : IMapper<ExampleSourceClass43, ExampleDTOClass43>
{
	public ExampleDTOClass43 Convert(ExampleSourceClass43 source)
    {
        return new ExampleDTOClass43
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
