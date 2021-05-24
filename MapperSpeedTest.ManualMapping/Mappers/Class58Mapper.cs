using System;
using MapperSpeedTest.ManualMapping;

public class Class58Mapper : IMapper<ExampleSourceClass58, ExampleDTOClass58>
{
	public ExampleDTOClass58 Convert(ExampleSourceClass58 source)
    {
        return new ExampleDTOClass58
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
