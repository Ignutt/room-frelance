using GameSystem;

namespace GarbageSystem
{
    public class BaseGarbage : Garbage
    {
        public override void CleanUp()
        {
            GameManager.Instance.RemoveGarbage(this);
            Destroy(gameObject);
        }

        public override void OnClick()
        {
            CleanUp();
        }
    }
}
