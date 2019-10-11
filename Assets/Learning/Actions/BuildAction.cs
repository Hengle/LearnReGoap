using System;
using ReGoap.Core;
using ReGoap.Unity;

namespace Learning.Actions
{
    public class BuildAction : ReGoapAction<string, object>
    {
        public override void Run(IReGoapAction<string, object> previous, IReGoapAction<string, object> next, ReGoapState<string, object> settings, ReGoapState<string, object> goalState,
            Action<IReGoapAction<string, object>> done, Action<IReGoapAction<string, object>> fail)
        {
            
        }
    }
}