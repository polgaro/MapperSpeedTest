using System;
using MapperSpeedTest.ManualMapping;

public class Class38Mapper : IMapper<ExampleSourceClass38, ExampleDTOClass38>
{
	public ExampleDTOClass38 Convert(ExampleSourceClass38 source)
    {
        return new ExampleDTOClass38
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
