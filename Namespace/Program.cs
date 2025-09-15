using UtilitiesLogger = Namespace.Utilities.MyLogger;
using ServicesLogger = Namespace.Services.MyLogger;


Console.WriteLine("\n--- Demonstrating Namespace Aliases ---");

var utilLogger = new UtilitiesLogger();
var svcLogger = new ServicesLogger();

utilLogger.LogMessage("This is a message from the aliased Utilities Logger.");