using System;
using MapperSpeedTest.ManualMapping;
using System.Collections.Generic;

namespace MapperSpeedTest.ManualMapping
{
    public static class ClassFactory
    {
        private static Dictionary<(Type, Type), object> _dictionary;

        public static IMapper<T, T2> GetMapper<T, T2>()
        {
            if(_dictionary == null)
            {
                InitializeDictionary();
            }

            return _dictionary[(typeof(T), typeof(T2))] as IMapper<T, T2>;
        }

        private static void InitializeDictionary()
        {
            _dictionary = new Dictionary<(Type, Type), object>();
            _dictionary.Add((typeof(ExampleSourceClass00), typeof(ExampleDTOClass00)), new Class00Mapper());
            _dictionary.Add((typeof(ExampleSourceClass01), typeof(ExampleDTOClass01)), new Class01Mapper());
            _dictionary.Add((typeof(ExampleSourceClass02), typeof(ExampleDTOClass02)), new Class02Mapper());
            _dictionary.Add((typeof(ExampleSourceClass03), typeof(ExampleDTOClass03)), new Class03Mapper());
            _dictionary.Add((typeof(ExampleSourceClass04), typeof(ExampleDTOClass04)), new Class04Mapper());
            _dictionary.Add((typeof(ExampleSourceClass05), typeof(ExampleDTOClass05)), new Class05Mapper());
            _dictionary.Add((typeof(ExampleSourceClass06), typeof(ExampleDTOClass06)), new Class06Mapper());
            _dictionary.Add((typeof(ExampleSourceClass07), typeof(ExampleDTOClass07)), new Class07Mapper());
            _dictionary.Add((typeof(ExampleSourceClass08), typeof(ExampleDTOClass08)), new Class08Mapper());
            _dictionary.Add((typeof(ExampleSourceClass09), typeof(ExampleDTOClass09)), new Class09Mapper());
            _dictionary.Add((typeof(ExampleSourceClass10), typeof(ExampleDTOClass10)), new Class10Mapper());
            _dictionary.Add((typeof(ExampleSourceClass11), typeof(ExampleDTOClass11)), new Class11Mapper());
            _dictionary.Add((typeof(ExampleSourceClass12), typeof(ExampleDTOClass12)), new Class12Mapper());
            _dictionary.Add((typeof(ExampleSourceClass13), typeof(ExampleDTOClass13)), new Class13Mapper());
            _dictionary.Add((typeof(ExampleSourceClass14), typeof(ExampleDTOClass14)), new Class14Mapper());
            _dictionary.Add((typeof(ExampleSourceClass15), typeof(ExampleDTOClass15)), new Class15Mapper());
            _dictionary.Add((typeof(ExampleSourceClass16), typeof(ExampleDTOClass16)), new Class16Mapper());
            _dictionary.Add((typeof(ExampleSourceClass17), typeof(ExampleDTOClass17)), new Class17Mapper());
            _dictionary.Add((typeof(ExampleSourceClass18), typeof(ExampleDTOClass18)), new Class18Mapper());
            _dictionary.Add((typeof(ExampleSourceClass19), typeof(ExampleDTOClass19)), new Class19Mapper());
            _dictionary.Add((typeof(ExampleSourceClass20), typeof(ExampleDTOClass20)), new Class20Mapper());
            _dictionary.Add((typeof(ExampleSourceClass21), typeof(ExampleDTOClass21)), new Class21Mapper());
            _dictionary.Add((typeof(ExampleSourceClass22), typeof(ExampleDTOClass22)), new Class22Mapper());
            _dictionary.Add((typeof(ExampleSourceClass23), typeof(ExampleDTOClass23)), new Class23Mapper());
            _dictionary.Add((typeof(ExampleSourceClass24), typeof(ExampleDTOClass24)), new Class24Mapper());
            _dictionary.Add((typeof(ExampleSourceClass25), typeof(ExampleDTOClass25)), new Class25Mapper());
            _dictionary.Add((typeof(ExampleSourceClass26), typeof(ExampleDTOClass26)), new Class26Mapper());
            _dictionary.Add((typeof(ExampleSourceClass27), typeof(ExampleDTOClass27)), new Class27Mapper());
            _dictionary.Add((typeof(ExampleSourceClass28), typeof(ExampleDTOClass28)), new Class28Mapper());
            _dictionary.Add((typeof(ExampleSourceClass29), typeof(ExampleDTOClass29)), new Class29Mapper());
            _dictionary.Add((typeof(ExampleSourceClass30), typeof(ExampleDTOClass30)), new Class30Mapper());
            _dictionary.Add((typeof(ExampleSourceClass31), typeof(ExampleDTOClass31)), new Class31Mapper());
            _dictionary.Add((typeof(ExampleSourceClass32), typeof(ExampleDTOClass32)), new Class32Mapper());
            _dictionary.Add((typeof(ExampleSourceClass33), typeof(ExampleDTOClass33)), new Class33Mapper());
            _dictionary.Add((typeof(ExampleSourceClass34), typeof(ExampleDTOClass34)), new Class34Mapper());
            _dictionary.Add((typeof(ExampleSourceClass35), typeof(ExampleDTOClass35)), new Class35Mapper());
            _dictionary.Add((typeof(ExampleSourceClass36), typeof(ExampleDTOClass36)), new Class36Mapper());
            _dictionary.Add((typeof(ExampleSourceClass37), typeof(ExampleDTOClass37)), new Class37Mapper());
            _dictionary.Add((typeof(ExampleSourceClass38), typeof(ExampleDTOClass38)), new Class38Mapper());
            _dictionary.Add((typeof(ExampleSourceClass39), typeof(ExampleDTOClass39)), new Class39Mapper());
            _dictionary.Add((typeof(ExampleSourceClass40), typeof(ExampleDTOClass40)), new Class40Mapper());
            _dictionary.Add((typeof(ExampleSourceClass41), typeof(ExampleDTOClass41)), new Class41Mapper());
            _dictionary.Add((typeof(ExampleSourceClass42), typeof(ExampleDTOClass42)), new Class42Mapper());
            _dictionary.Add((typeof(ExampleSourceClass43), typeof(ExampleDTOClass43)), new Class43Mapper());
            _dictionary.Add((typeof(ExampleSourceClass44), typeof(ExampleDTOClass44)), new Class44Mapper());
            _dictionary.Add((typeof(ExampleSourceClass45), typeof(ExampleDTOClass45)), new Class45Mapper());
            _dictionary.Add((typeof(ExampleSourceClass46), typeof(ExampleDTOClass46)), new Class46Mapper());
            _dictionary.Add((typeof(ExampleSourceClass47), typeof(ExampleDTOClass47)), new Class47Mapper());
            _dictionary.Add((typeof(ExampleSourceClass48), typeof(ExampleDTOClass48)), new Class48Mapper());
            _dictionary.Add((typeof(ExampleSourceClass49), typeof(ExampleDTOClass49)), new Class49Mapper());
            _dictionary.Add((typeof(ExampleSourceClass50), typeof(ExampleDTOClass50)), new Class50Mapper());
            _dictionary.Add((typeof(ExampleSourceClass51), typeof(ExampleDTOClass51)), new Class51Mapper());
            _dictionary.Add((typeof(ExampleSourceClass52), typeof(ExampleDTOClass52)), new Class52Mapper());
            _dictionary.Add((typeof(ExampleSourceClass53), typeof(ExampleDTOClass53)), new Class53Mapper());
            _dictionary.Add((typeof(ExampleSourceClass54), typeof(ExampleDTOClass54)), new Class54Mapper());
            _dictionary.Add((typeof(ExampleSourceClass55), typeof(ExampleDTOClass55)), new Class55Mapper());
            _dictionary.Add((typeof(ExampleSourceClass56), typeof(ExampleDTOClass56)), new Class56Mapper());
            _dictionary.Add((typeof(ExampleSourceClass57), typeof(ExampleDTOClass57)), new Class57Mapper());
            _dictionary.Add((typeof(ExampleSourceClass58), typeof(ExampleDTOClass58)), new Class58Mapper());
            _dictionary.Add((typeof(ExampleSourceClass59), typeof(ExampleDTOClass59)), new Class59Mapper());
            _dictionary.Add((typeof(ExampleSourceClass60), typeof(ExampleDTOClass60)), new Class60Mapper());
            _dictionary.Add((typeof(ExampleSourceClass61), typeof(ExampleDTOClass61)), new Class61Mapper());
            _dictionary.Add((typeof(ExampleSourceClass62), typeof(ExampleDTOClass62)), new Class62Mapper());
            _dictionary.Add((typeof(ExampleSourceClass63), typeof(ExampleDTOClass63)), new Class63Mapper());
            _dictionary.Add((typeof(ExampleSourceClass64), typeof(ExampleDTOClass64)), new Class64Mapper());
            _dictionary.Add((typeof(ExampleSourceClass65), typeof(ExampleDTOClass65)), new Class65Mapper());
            _dictionary.Add((typeof(ExampleSourceClass66), typeof(ExampleDTOClass66)), new Class66Mapper());
            _dictionary.Add((typeof(ExampleSourceClass67), typeof(ExampleDTOClass67)), new Class67Mapper());
            _dictionary.Add((typeof(ExampleSourceClass68), typeof(ExampleDTOClass68)), new Class68Mapper());
            _dictionary.Add((typeof(ExampleSourceClass69), typeof(ExampleDTOClass69)), new Class69Mapper());
            _dictionary.Add((typeof(ExampleSourceClass70), typeof(ExampleDTOClass70)), new Class70Mapper());
            _dictionary.Add((typeof(ExampleSourceClass71), typeof(ExampleDTOClass71)), new Class71Mapper());
            _dictionary.Add((typeof(ExampleSourceClass72), typeof(ExampleDTOClass72)), new Class72Mapper());
            _dictionary.Add((typeof(ExampleSourceClass73), typeof(ExampleDTOClass73)), new Class73Mapper());
            _dictionary.Add((typeof(ExampleSourceClass74), typeof(ExampleDTOClass74)), new Class74Mapper());
            _dictionary.Add((typeof(ExampleSourceClass75), typeof(ExampleDTOClass75)), new Class75Mapper());
            _dictionary.Add((typeof(ExampleSourceClass76), typeof(ExampleDTOClass76)), new Class76Mapper());
            _dictionary.Add((typeof(ExampleSourceClass77), typeof(ExampleDTOClass77)), new Class77Mapper());
            _dictionary.Add((typeof(ExampleSourceClass78), typeof(ExampleDTOClass78)), new Class78Mapper());
            _dictionary.Add((typeof(ExampleSourceClass79), typeof(ExampleDTOClass79)), new Class79Mapper());
            _dictionary.Add((typeof(ExampleSourceClass80), typeof(ExampleDTOClass80)), new Class80Mapper());
            _dictionary.Add((typeof(ExampleSourceClass81), typeof(ExampleDTOClass81)), new Class81Mapper());
            _dictionary.Add((typeof(ExampleSourceClass82), typeof(ExampleDTOClass82)), new Class82Mapper());
            _dictionary.Add((typeof(ExampleSourceClass83), typeof(ExampleDTOClass83)), new Class83Mapper());
            _dictionary.Add((typeof(ExampleSourceClass84), typeof(ExampleDTOClass84)), new Class84Mapper());
            _dictionary.Add((typeof(ExampleSourceClass85), typeof(ExampleDTOClass85)), new Class85Mapper());
            _dictionary.Add((typeof(ExampleSourceClass86), typeof(ExampleDTOClass86)), new Class86Mapper());
            _dictionary.Add((typeof(ExampleSourceClass87), typeof(ExampleDTOClass87)), new Class87Mapper());
            _dictionary.Add((typeof(ExampleSourceClass88), typeof(ExampleDTOClass88)), new Class88Mapper());
            _dictionary.Add((typeof(ExampleSourceClass89), typeof(ExampleDTOClass89)), new Class89Mapper());
            _dictionary.Add((typeof(ExampleSourceClass90), typeof(ExampleDTOClass90)), new Class90Mapper());
            _dictionary.Add((typeof(ExampleSourceClass91), typeof(ExampleDTOClass91)), new Class91Mapper());
            _dictionary.Add((typeof(ExampleSourceClass92), typeof(ExampleDTOClass92)), new Class92Mapper());
            _dictionary.Add((typeof(ExampleSourceClass93), typeof(ExampleDTOClass93)), new Class93Mapper());
            _dictionary.Add((typeof(ExampleSourceClass94), typeof(ExampleDTOClass94)), new Class94Mapper());
            _dictionary.Add((typeof(ExampleSourceClass95), typeof(ExampleDTOClass95)), new Class95Mapper());
            _dictionary.Add((typeof(ExampleSourceClass96), typeof(ExampleDTOClass96)), new Class96Mapper());
            _dictionary.Add((typeof(ExampleSourceClass97), typeof(ExampleDTOClass97)), new Class97Mapper());
            _dictionary.Add((typeof(ExampleSourceClass98), typeof(ExampleDTOClass98)), new Class98Mapper());
            _dictionary.Add((typeof(ExampleSourceClass99), typeof(ExampleDTOClass99)), new Class99Mapper());
        }
    }
}

