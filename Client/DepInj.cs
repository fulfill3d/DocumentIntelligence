using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
    public static class DepInj
    {
        public static void RegisterDocumentIntelligenceClient(
            this IServiceCollection service,
            Action<DocumentIntelligenceOptions> configureOptions)
        {
            service.ConfigureServiceOptions<DocumentIntelligenceOptions>((_, opt) => configureOptions(opt));
            service.AddTransient<IDocumentIntelligenceClient, DocumentIntelligenceClient>();
        }

        private static void ConfigureServiceOptions<TOptions>(
            this IServiceCollection services,
            Action<IServiceProvider, TOptions> configure)
            where TOptions : class
        {
            services
                .AddOptions<TOptions>()
                .Configure<IServiceProvider>((options, resolver) => configure(resolver, options));
        }
    }
}