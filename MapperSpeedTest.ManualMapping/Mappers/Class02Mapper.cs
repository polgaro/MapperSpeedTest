using System;
using MapperSpeedTest.ManualMapping;

public class Class02Mapper : IMapper<ExampleSourceClass02, ExampleDTOClass02>
{
	public ExampleDTOClass02 Convert(ExampleSourceClass02 source)
    {
        return new ExampleDTOClass02
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
