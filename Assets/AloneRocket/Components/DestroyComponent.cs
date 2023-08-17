using UnityEngine;

namespace Assets.AloneRocket.Components
{
    public class DestroyComponent : MonoBehaviour
    {
        public void DestroyObject()
        {
            Destroy(gameObject);
        }       
    }
}
