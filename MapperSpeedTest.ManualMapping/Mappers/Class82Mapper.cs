using System;
using MapperSpeedTest.ManualMapping;

public class Class82Mapper : IMapper<ExampleSourceClass82, ExampleDTOClass82>
{
	public ExampleDTOClass82 Convert(ExampleSourceClass82 source)
    {
        return new ExampleDTOClass82
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
