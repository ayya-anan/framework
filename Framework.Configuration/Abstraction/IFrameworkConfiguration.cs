using Framework.Configuration.Entity;

namespace Framework.Configuration.Abstraction
{    
    public interface IFrameworkConfiguration
    {
        Dictionary<string,string> GetGlobalConfigurations();
        string GetGlobalConfigurationByKey(string key);
        Dictionary<string, string> GetTenantConfigurations(Tenant tenant);
        string GetTenantConfigurationByKey(Tenant tenant, string key);
    }
}
