using MapperSpeedTest.Common;
using MapperSpeedTest.Entities;
using System;
using System.Diagnostics;
using System.Linq;

namespace MapperSpeedTest.Automapper
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
                test = "Automapper with explicit profile.";
                Console.WriteLine($"Test {test} starting with {count} count!");
                sw.Start();

                var mapper = MappingProfileConfiguration.InitializeAutoMapper().CreateMapper();

                for (int i = 0; i < count; i++)
                {
                    var source = Class00Helper.GenerateRandom();
                    var response = mapper.Map<ExampleDTOClass00>(source);
                    CommonHelper.ValidateTransformation(source, response);
                }

                sw.Stop();
            }
            else
            {
                test = "Automapper with implicit profile.";
                //https://docs.automapper.org/en/stable/9.0-Upgrade-Guide.html#automapper-no-longer-creates-maps-automatically-createmissingtypemaps-and-conventions
                throw new Exception("You just can't do implicit. Sorry.");
            }
            Console.WriteLine($"Test {test} with {count} count took {sw.ElapsedMilliseconds} milliseconds");
        }
    }
}
