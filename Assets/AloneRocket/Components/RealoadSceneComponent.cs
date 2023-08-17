using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.AloneRocket.Components
{
    public class RealoadSceneComponent : MonoBehaviour
    {
        public void RealoadScene() 
        {
            var activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.name);
        }
    }
}
