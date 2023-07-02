using _00_Presentacion.IoC_Container;
using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.ValueObject;
using Autofac;

IContainer container = IoCContainer.getContainer();

AutomovilDTO Fiat = new AutomovilDTO(
    "TOJ809",
    "Fiat",
    "2013",
    120000
);


CrearAutomovil creadorDeAutomoviles = container.Resolve<CrearAutomovil>();
creadorDeAutomoviles.ejecutar(Fiat);

EliminarAutomovil eliminarAutomovil = container.Resolve<EliminarAutomovil>();
eliminarAutomovil.Ejecutar("TOJ808");

ActualizarAutomovil actualizarAutomovil = container.Resolve<ActualizarAutomovil>();
actualizarAutomovil.ejecutar("TOJ806", "Fiat", "2013", 120000);

ObtenerAutomovil obtenedorDeAutomoviles = container.Resolve<ObtenerAutomovil>();

List<AutomovilDTO> todosLosAutomoviles = obtenedorDeAutomoviles.ejecutar();
foreach (AutomovilDTO automovil in todosLosAutomoviles)
{
    Console.WriteLine(automovil.presentacion());
}



