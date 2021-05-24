using System;
using MapperSpeedTest.ManualMapping;

public class Class89Mapper : IMapper<ExampleSourceClass89, ExampleDTOClass89>
{
	public ExampleDTOClass89 Convert(ExampleSourceClass89 source)
    {
        return new ExampleDTOClass89
        {
            Property1 = source.Property1,
            Property2 = source.Property2,
            Property3 = source.Property3,
        };
    }
}
