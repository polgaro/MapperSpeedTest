using System;
using MapperSpeedTest.ManualMapping;

public class Class80Mapper : IMapper<ExampleSourceClass80, ExampleDTOClass80>
{
	public ExampleDTOClass80 Convert(ExampleSourceClass80 source)
    {
        return new ExampleDTOClass80
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
