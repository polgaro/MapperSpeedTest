using System;
using MapperSpeedTest.ManualMapping;

public class Class52Mapper : IMapper<ExampleSourceClass52, ExampleDTOClass52>
{
	public ExampleDTOClass52 Convert(ExampleSourceClass52 source)
    {
        return new ExampleDTOClass52
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
