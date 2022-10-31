using Blazored.Modal;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SARAS.Frontend.FuenteDatos.HttpRepositorio;
using SARAS.Frontend.PD.GenericaPersistenciaDatos;
using SARAS.Frontend.Transversal.Helpers;
using SARAS.Frontend.Wasm;

//using Blazored.Modal;
//using Blazored.SessionStorage;
//using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.BancosAplicacion;
//using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.MonedasAplicacion;
//using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoCuentasAplicacion;
//using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoDocumentoAplicacion;
//using SARASWEB.Frontend.Aplicacion.ProductosAplicacion;
//using SARASWEB.Frontend.Controlador.TransferenciaPropiaControlador;
//using SARASWEB.Frontend.Controlador.TransferenciaTercerosControlador;
//using SARASWEB.Frontend.FuenteDatos.HttpRepositorio;
//using SARASWEB.Frontend.PD.GenericaPersistenciaDatos;
//using SARASWEB.Frontend.PD;
//using SARASWEB.Frontend.Transversal.Helpers;
//using SARASWEB.Frontend.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddTransient<IHelpers, Helpers>();
builder.Services.AddTransient<IHttpRepositorio, HttpRepositorio>();
builder.Services.AddTransient<IGenericaPersistenciaDatos, GenericaPersistenciaDatos>();
builder.Services.AddBlazoredModal();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredSessionStorage(config =>
config.JsonSerializerOptions.WriteIndented = true);


await builder.Build().RunAsync();
