using ReGoap.Unity;

namespace Learning.Goals
{
    public class KeepStaminaGoal : ReGoapGoal<string, object>
    {
        protected override void Awake()
        {
            base.Awake();
            goal.Set("stamina", true);
        }
    }
}