using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using RestaurantFinder.Services;
using Unity;

namespace RestaurantFinder
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IRestaurantService, RestaurantService>()
                .RegisterType<IApiService, ApiService>();

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic VGVjaFRlc3Q6bkQ2NGxXVnZreDVw");
            httpClient.DefaultRequestHeaders.Add("Host", "public.je-apis.com");

            container.RegisterInstance(httpClient);
        }
    }
}