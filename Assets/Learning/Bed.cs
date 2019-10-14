using System;
using UnityEngine;

namespace Learning
{
    public class Bed : MonoBehaviour
    {
        public float effect = 0.5f;
        public Vector3 position;

        private void Awake()
        {
            position = GetComponent<Transform>().position;
        }

        public void Sleep(Stamina stamina)
        {
            stamina.Value += effect;
        }
    }
}