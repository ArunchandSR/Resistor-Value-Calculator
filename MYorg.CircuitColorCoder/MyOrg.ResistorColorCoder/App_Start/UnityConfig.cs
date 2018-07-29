using Microsoft.Practices.Unity;
using MyOrg.CircuitColorCoder.BL.Abstractions;
using MyOrg.CircuitColorCoder.BL.Implementations;
using System.Web.Mvc;
using Unity.Mvc5;

namespace MyOrg.ResistorColorCoder
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IResistorValueCalculator, ResistorValueCalculator>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}