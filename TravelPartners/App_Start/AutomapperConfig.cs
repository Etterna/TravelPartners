using AutoMapper;
using TravelPartners.AutomapperProfiles;

namespace TravelPartners.App_Start
{
    public static class AutomapperConfig
    {
        public static void Register()
        {
            ConfigureMapping();
        }
        
        private static void ConfigureMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ModelProfile>();
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}