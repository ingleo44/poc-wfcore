using System;
using Microsoft.Extensions.Logging;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace POC_RuleGenerator.Steps
{
    public class LogicStep : StepBody
    {

        private ILogger _logger;

        public LogicStep(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<LogicStep>();
        }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            return ExecutionResult.Next();
        }
    }
}
