﻿using Microsoft.Practices.Unity;
using Treinamento.Domain.Repositories.Infrastructures;
using Treinamento.Domain.Repositories.Services;
using Treinamento.Infra.Contexts;
using Treinamento.Infra.Repositories;
using Treinamento.Service.Repositories;

namespace Treinamento.Common
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<ICustomerRepository, CustomerRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICustomerService, CustomerServices>(new HierarchicalLifetimeManager());
        }
    }
}
