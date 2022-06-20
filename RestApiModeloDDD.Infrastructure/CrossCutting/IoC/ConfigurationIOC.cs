using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using RestApiModeloDDD.Infrastructure.CrossCutting.Mapper;
using RestApiModeloDDD.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IoC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Ioc

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion Ioc
        }
    }
}