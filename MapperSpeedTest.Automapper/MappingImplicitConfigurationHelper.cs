using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapperSpeedTest.Automapper
{
    public static class MappingImplicitConfigurationHelper
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(new AutoMapper.Configuration.MapperConfigurationExpression 
            {
                
            });
            return config;
        }
    }
}
