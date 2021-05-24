using System;
using MapperSpeedTest.ManualMapping;

public class Class03Mapper : IMapper<ExampleSourceClass03, ExampleDTOClass03>
{
	public ExampleDTOClass03 Convert(ExampleSourceClass03 source)
    {
        return new ExampleDTOClass03
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
