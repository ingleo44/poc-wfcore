using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POC_RuleGenerator.Steps;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace POC_RuleGenerator
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .UseDefaultErrorBehavior(WorkflowErrorHandling.Suspend)
                .StartWith<ExecuteOperation>()
                .Then<LogicStep>();
        }

        public string Id => "ExecuteOperation";

        public int Version => 1;

    }
}
