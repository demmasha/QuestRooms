using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using QuestRoomsBLL.Mapping;
using QuestRoomsBLL.Services.Abstraction;
using QuestRoomsBLL.Services.Implementation;
using QuestRoomsDAL;
using QuestRoomsDAL.Entities;
using QuestRoomsDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomsUI.App_Start
{
    public class AutoFacConfig
    {
        public static void ConfigAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterTypes(builder);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
        private static void RegisterTypes(ContainerBuilder _builder)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });
            Mapper mapper = new Mapper(mapperConfig);
            _builder.RegisterInstance(mapper).As<IMapper>();
            _builder.RegisterType<RoomsContext>().As<DbContext>();
            _builder.RegisterGeneric(typeof(GenericREpositoriy<>)).As(typeof(IGenericRepository<>));
            _builder.RegisterType<CityService>().As<ICityService>();
        }
    }
}