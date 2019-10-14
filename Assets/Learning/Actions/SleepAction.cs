using System;
using System.Collections.Generic;
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
            if (stackData.settings.HasKey("bed"))
            {
                preconditions.Set("isAtPosition", stackData.settings.Get("bedPosition"));
            }

            return preconditions;
        }

        public override ReGoapState<string, object> GetEffects(GoapActionStackData<string, object> stackData)
        {
            effects.Clear();
            if (stackData.settings.HasKey("bed"))
            {
                effects.Set("stamina", true);
            }
            return effects;
        }

        public override List<ReGoapState<string, object>> GetSettings(GoapActionStackData<string, object> stackData)
        {
            settings.Clear();
            if(stackData.currentState.HasKey("beds"))
            {
                var results = new List<ReGoapState<string, object>>();
                var beds = (Bed[])stackData.currentState.Get("beds");
                foreach (var bed in beds)
                {
                    settings.Set("bed", bed);
                    settings.Set("bedPosition", bed.position);
                    results.Add(settings.Clone());
                }

                return results;
            }
            return new List<ReGoapState<string, object>>();
        }

        public override bool CheckProceduralCondition(GoapActionStackData<string, object> stackData)
        {
            return base.CheckProceduralCondition(stackData) && stackData.settings.HasKey("bed");;
        }

        public override void Run(IReGoapAction<string, object> previous, IReGoapAction<string, object> next, ReGoapState<string, object> settings, ReGoapState<string, object> goalState,
            Action<IReGoapAction<string, object>> done, Action<IReGoapAction<string, object>> fail)
        {
            base.Run(previous, next, settings, goalState, done, fail);

            var bed = (Bed) settings.Get("bed");
            if (bed == null)
                failCallback(this);
            else
            {
                bed.Sleep(stamina);
            }
        }
    }
}