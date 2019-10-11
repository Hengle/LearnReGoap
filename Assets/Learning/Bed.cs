using UnityEngine;

namespace Learning
{
    public class Bed : MonoBehaviour
    {
        public void Sleep(Stamina stamina)
        {
            stamina.Value += 0.7f;
        }
    }
}