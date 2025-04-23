global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using de.patrickkreft.cfe.Models;
global using de.patrickkreft.cfe.Presentation;
global using de.patrickkreft.cfe.DataContracts;
global using de.patrickkreft.cfe.DataContracts.Serialization;
global using de.patrickkreft.cfe.Services.Caching;
global using de.patrickkreft.cfe.Services.Endpoints;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;

[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]