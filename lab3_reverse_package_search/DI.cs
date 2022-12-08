using Microsoft.Extensions.DependencyInjection;

namespace Lab3;
public static class DependencyInjection 
{
    //<PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="1.0.0" />
    public static IServiceCollection  Application(this IServiceCollection  services)
    {
        return services;
    }




}