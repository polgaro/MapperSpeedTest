using AutoMapper;

namespace MapperSpeedTest.Automapper
{
    public static class MappingProfileConfiguration
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var profile = new MyProfile();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(profile);
                });
            return config;
        }
    }
}
