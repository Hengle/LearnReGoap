using UnityEngine;

namespace Learning
{
    public class Stamina : MonoBehaviour
    {
        public float value;

        public float Value
        {
            get => value;
            set
            {
                if (value > 1) value = 1;
                Debug.Log("Set Stamina to " + value);
                this.value = value;
            }
        }
    }
}