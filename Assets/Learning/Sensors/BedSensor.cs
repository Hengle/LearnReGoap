using System;
using ReGoap.Unity;
using UnityEngine;

namespace Learning.Sensors
{
    public class BedSensor : ReGoapSensor<string, object>
    {
        private void Start()
        {
            var worldState = memory.GetWorldState();
            var beds = FindObjectsOfType<Bed>();
            worldState.Set("beds", beds);
        }
    }
}