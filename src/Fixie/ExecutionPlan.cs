﻿using Fixie.Behaviors;
using Fixie.Conventions;

namespace Fixie
{
    public class ExecutionPlan
    {
        readonly ClassBehavior classBehavior;
        readonly InstanceBehavior instanceBehavior;
        readonly CaseBehavior caseBehavior;

        public ExecutionPlan(Convention convention)
        {
            classBehavior = convention.ClassExecution.BuildBehavior();
            instanceBehavior = convention.InstanceExecution.BuildBehavior();
            caseBehavior = convention.CaseExecution.BuildBehavior();
        }

        public void Execute(ClassExecution classExecution)
        {
            classBehavior.Execute(classExecution);
        }

        public void Execute(InstanceExecution instanceExecution)
        {
            instanceBehavior.Execute(instanceExecution);
        }

        public void Execute(CaseExecution caseExecution, object instance)
        {
            caseBehavior.Execute(caseExecution, instance);
        }
    }
}