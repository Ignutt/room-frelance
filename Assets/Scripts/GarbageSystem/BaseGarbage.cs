using GameSystem;

namespace GarbageSystem
{
    public class BaseGarbage : Garbage
    {
        public override void CleanUp()
        {
            GameManager.Instance.RemoveGarbage(this);
            gameObject.SetActive(false);
            base.CleanUp();
        }

        public override void OnClick()
        {
            CleanUp();
        }
    }
}
