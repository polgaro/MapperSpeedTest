using MapperSpeedTest.Common;
using MapperSpeedTest.Entities;
using Mapster;
using System;
using System.Diagnostics;
using System.Linq;

namespace MapperSpeedTest.Mapster
{
    class Program
    {
        static void Main(string[] args)
        {
            var argReader = new CustomArgumentReader(args);
            string test = "";
            int count = argReader.GetCount();
            var sw = new Stopwatch();

            if (argReader.GetExplicit())
            {
                test = "Mapster with explicit mapping.";

                Console.WriteLine($"Test {test} starting with {count} count!");
                sw.Start();

                MappingConfiguratorHelper.InitializeMapster();

                for (int i = 0; i < count; i++)
                {
                    var source = Class00Helper.GenerateRandom();
                    var response = source.Adapt<ExampleDTOClass00>();
                    CommonHelper.ValidateTransformation(source, response);
                }

                sw.Stop();
            }
            else
            {
                test = "Mapster with implicit mapping.";
                Console.WriteLine($"Test {test} starting with {count} count!");
                sw.Start();

                for (int i = 0; i < count; i++)
                {
                    var source = Class00Helper.GenerateRandom();
                    var response = source.Adapt<ExampleDTOClass00>();
                    CommonHelper.ValidateTransformation(source, response);
                }

                sw.Stop();
            }

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
