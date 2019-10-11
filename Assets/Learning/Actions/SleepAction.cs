using System;
using ReGoap.Core;
using ReGoap.Unity;
using UnityEngine;

namespace Learning.Actions
{
    [RequireComponent(typeof(Stamina))]
    public class SleepAction : ReGoapAction<string, object>
    {
        private Stamina stamina;
        
        protected override void Awake()
        {
            base.Awake();
            stamina = GetComponent<Stamina>();
        }

        public override ReGoapState<string, object> GetPreconditions(GoapActionStackData<string, object> stackData)
        {
            preconditions.Clear();
            //todo 
            if (stackData.settings.HasKey("bed"))
            {
                preconditions.Set("isAtPosition", stackData.settings.Get("bedPosition"));
            }
            return preconditions;
        }

        public override void Run(IReGoapAction<string, object> previous, IReGoapAction<string, object> next, ReGoapState<string, object> settings, ReGoapState<string, object> goalState,
            Action<IReGoapAction<string, object>> done, Action<IReGoapAction<string, object>> fail)
        {
            base.Run(previous, next, settings, goalState, done, fail);
            
            
        }
    }
}