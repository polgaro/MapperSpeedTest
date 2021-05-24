using System;
using MapperSpeedTest.ManualMapping;

public class Class71Mapper : IMapper<ExampleSourceClass71, ExampleDTOClass71>
{
	public ExampleDTOClass71 Convert(ExampleSourceClass71 source)
    {
        return new ExampleDTOClass71
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
