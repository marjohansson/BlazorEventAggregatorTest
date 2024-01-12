using Microsoft.Extensions.DependencyInjection;

namespace CM.Micro.EventAggregator.Lib
{

    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds IEventAggregator as a singleton
        /// </summary>
        /// <param name="services">Service collection</param>
        /// <returns>Service collection</returns>
        public static IServiceCollection AddEventAggregator(this IServiceCollection services, Action<EventAggregatorOptions> configure = null)
        {
            services.AddSingleton<IEventAggregator, EventAggregator>();

            if (configure != null)
            {
                services.Configure(configure);
            }

            return services;
        }
    }
}
