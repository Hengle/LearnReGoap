using UnityEngine;

namespace Learning
{
    public class Stamina : MonoBehaviour
    {
        private float value;

        public float Value
        {
            get => value;
            set
            {
                if (value > 1) value = 1;
                this.value = value;
            }
        }
    }
}