using System;
using MapperSpeedTest.ManualMapping;

public class Class22Mapper : IMapper<ExampleSourceClass22, ExampleDTOClass22>
{
	public ExampleDTOClass22 Convert(ExampleSourceClass22 source)
    {
        return new ExampleDTOClass22
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
