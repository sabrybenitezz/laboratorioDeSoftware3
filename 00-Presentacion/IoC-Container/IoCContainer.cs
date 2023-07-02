using _01_Aplicacion;
using _02_Dominio.Repositorio;
using _03_Infraestructura;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Presentacion.IoC_Container
{
    static public class IoCContainer
    {
        static public IContainer getContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
           //builder.RegisterType<AutomovilRepositorioEnMemoria>().As<AutomovilRepositorio>().SingleInstance();
            builder.RegisterType<AutomovilRepositorioSQLServer>().As<AutomovilRepositorio>().SingleInstance();
            builder.RegisterType<CrearAutomovil>();
            builder.RegisterType<ObtenerAutomovil>();
            builder.RegisterType<EliminarAutomovil>();
            builder.RegisterType<ActualizarAutomovil>();

            IContainer container = builder.Build();

            return container;
        }
    }
}
