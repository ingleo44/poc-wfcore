using System;
using System.Collections.Generic;
using System.Reflection;
using NCalc;
using Newtonsoft.Json.Linq;
using POC_RuleGenerator.model;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace POC_RuleGenerator.Steps
{
    public class ExecuteOperation : StepBody
    {
        public object InputParameters { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            try
            {
                var jsonObject = (JObject)InputParameters;
                var formula = (string)jsonObject.SelectToken("formula");
                var resultField = (string)jsonObject.SelectToken("resultField");
                var data = (DummyDataClass)context.Workflow.Data;
                var e = new Expression(formula);

                IList<PropertyInfo> props = new List<PropertyInfo>(data.GetType().GetProperties());
                foreach (var prop in props)
                {
                    e.Parameters.Add(prop.Name, prop.GetValue(data, null));
                    // Do something with propValue
                }

                var outputProperty = data.GetType().GetProperty(resultField);
                var result = e.Evaluate();

                try
                {
                    if (outputProperty != null)
                    {
                        outputProperty.SetValue(data, result);
                        Console.WriteLine("The property " + outputProperty.Name + " was setted to the value " + result.ToString());
                    }
                    else
                    {
                        throw new Exception("The result field provided was not found");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The result of the operation is of type " + result.GetType() + " this value is not assignable to the output property type " + outputProperty.GetType());
                    throw;
                }

                //Console.WriteLine("property " + outputProperty.Name + "was setted to " + result);
                return ExecutionResult.Next();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
    }
}
