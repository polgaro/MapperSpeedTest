using System;
using MapperSpeedTest.ManualMapping;

public class Class10Mapper : IMapper<ExampleSourceClass10, ExampleDTOClass10>
{
	public ExampleDTOClass10 Convert(ExampleSourceClass10 source)
    {
        return new ExampleDTOClass10
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
