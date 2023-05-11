using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using POC_RuleGenerator.model;
using WorkflowCore.Interface;
using WorkflowCore.Services.DefinitionStorage;

namespace POC_RuleGenerator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var json = "";
            using (var r = new StreamReader("Json/Test.json"))
            {
                json = r.ReadToEnd();
            }
            var serviceProvider = ConfigureServices();

            var data = new DummyDataClass();
            data.AllInclusive = true;
            data.FiscalParadise = true;
            data.FreePass = false;
            data.BaseCharges = 10;
            data.BaseTaxes = 1;
            data.Comsumption = 100;
            data.ComsumptionTaxes = 20;


            //start the workflow host
            var host = serviceProvider.GetService<IWorkflowHost>();
            var definitionLoader = serviceProvider.GetService<IDefinitionLoader>();
            var def = definitionLoader.LoadDefinition(json, Deserializers.Json);
            host.Start();
            host.StartWorkflow("test", version:1, data);
            Console.ReadLine();
            host.Stop();
        }

        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddWorkflow();
            services.AddWorkflowDSL();
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        } 

    }
}
