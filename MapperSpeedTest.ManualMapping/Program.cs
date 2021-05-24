using MapperSpeedTest.Common;
using MapperSpeedTest.Entities;
using System;
using System.Diagnostics;

namespace MapperSpeedTest.ManualMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var argReader = new CustomArgumentReader(args);
            string test = "Manual mapping.";
            int count = argReader.GetCount();
            Console.WriteLine($"Test {test} starting with {count} count!");
            var sw = new Stopwatch();
            sw.Start();

            var mapper = ClassFactory.GetMapper<ExampleSourceClass00, ExampleDTOClass00>();

            for (int i = 0; i < count; i++)
            {
                var source = Class00Helper.GenerateRandom();
                var response = mapper.Convert(source);
                CommonHelper.ValidateTransformation(source, response);
            }

            sw.Stop();

            Console.WriteLine($"Test {test} with {count} count took {sw.ElapsedMilliseconds} milliseconds");
        }

        private static void ValidateTransformation(ExampleSourceClass00 source, ExampleDTOClass00 response)
        {
            if (response.Property1 != source.Property1)
            {
                throw new Exception("Problem in mapping");
            }
        }
    }
}
