﻿using MongoDB.Driver;
using Planru.Core.Module.WebAPI;
using Planru.Crosscutting.Adapter;
using Planru.Crosscutting.Adapter.Automapper;
using Planru.Crosscutting.IoC;
using Planru.Crosscutting.IoC.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planru.DistributedServices.WebAPI
{
    public class IoCConfig
    {
        private static Lazy<IContainer> _container = new Lazy<IContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IContainer GetConfiguredContainer()
        {
            return _container.Value;
        }

        public static void RegisterTypes(IContainer container)
        {
            TypeAdapterFactory.SetCurrent(new SingletonAutomapperTypeAdapterFactory());
            container.RegisterInstance<MongoDatabase>(MongoDbConfig.GetMongoDbDatabase());
        }
    }
}